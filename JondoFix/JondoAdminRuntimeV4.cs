using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using HarmonyLib;
using Il2CppCore.UILogic.Admin;
using Il2CppQFSW.QC;
using MelonLoader;
using UnityEngine;

namespace JondoFix
{
    public static class JondoAdminRuntimeV4
    {
        private static bool _f9Down;
        private static bool _menuScanDone;
        private static AdminMenu _capturedMenu;

        private const int VkF9 = 0x78;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int virtualKey);

        public static void Update()
        {
            if (!JondoFixMod.IsJondoAdministrator)
                return;

            bool down = (GetAsyncKeyState(VkF9) & 0x8000) != 0;

            if (down && !_f9Down)
            {
                ToggleCanvas();
            }

            _f9Down = down;
        }

        public static void ToggleCanvas()
        {
            try
            {
                MethodInfo method = AccessTools.Method(
                    typeof(JondoAdminCanvas),
                    "TogglePanel"
                );

                method?.Invoke(null, null);
                MelonLogger.Msg("[JondoAdminV4] F9 : Canvas bascule.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error("[JondoAdminV4] F9 : " + ex);
            }
        }

        public static void SetStatus(string message)
        {
            MelonLogger.Msg("[JondoAdminV4] " + message);

            try
            {
                MethodInfo method = AccessTools.Method(
                    typeof(JondoAdminCanvas),
                    "SetStatus"
                );

                method?.Invoke(null, new object[] { message });
            }
            catch
            {
                // Le message reste disponible dans le journal MelonLoader.
            }
        }

        public static void ToggleQuantum()
        {
            try
            {
                QuantumConsole console = QuantumConsole.Instance;

                if (IsValid(console))
                {
                    console.Toggle();
                    SetStatus(
                        "QuantumConsole existante : " +
                        (console.IsActive ? "ouverte." : "fermee.")
                    );
                    return;
                }

                QuantumConsole[] candidates =
                    Resources.FindObjectsOfTypeAll<QuantumConsole>();

                int count = candidates == null ? 0 : candidates.Length;

                MelonLogger.Msg(
                    "[JondoAdminV4] QuantumConsole chargees : " + count
                );

                for (int i = 0; i < count; i++)
                {
                    QuantumConsole source = candidates[i];

                    if (!IsValid(source) || source.gameObject == null)
                        continue;

                    try
                    {
                        GameObject clone =
                            UnityEngine.Object.Instantiate(source.gameObject);

                        clone.name = "JondoQuantumConsole";
                        UnityEngine.Object.DontDestroyOnLoad(clone);
                        clone.SetActive(true);

                        console = QuantumConsole.Instance;

                        if (!IsValid(console))
                            console = clone.GetComponent<QuantumConsole>();

                        if (!IsValid(console))
                        {
                            UnityEngine.Object.Destroy(clone);
                            continue;
                        }

                        console.Activate();

                        SetStatus(
                            "QuantumConsole instanciee depuis : " +
                            source.gameObject.name
                        );
                        return;
                    }
                    catch (Exception candidateError)
                    {
                        MelonLogger.Warning(
                            "[JondoAdminV4] Prefab Quantum refuse : " +
                            candidateError.Message
                        );
                    }
                }

                SetStatus(
                    "Aucune instance ni prefab QuantumConsole charge dans les assets actifs."
                );
            }
            catch (Exception ex)
            {
                SetStatus("QuantumConsole erreur : " + ex.Message);
                MelonLogger.Error("[JondoAdminV4] " + ex);
            }
        }

        private static bool IsValid(QuantumConsole console)
        {
            return console != null && console.Pointer != IntPtr.Zero;
        }

        public static void CaptureMenu(AdminMenu menu)
        {
            if (menu == null || menu.Pointer == IntPtr.Zero)
                return;

            _capturedMenu = menu;
            JondoAdminTools.CaptureOfficialMenu(menu);

            MelonLogger.Msg(
                "[JondoAdminV4] Instance AdminMenu capturee."
            );
        }

        public static bool PrepareOfficialMenu()
        {
            AdminMenu menu = null;

            try
            {
                menu = CurrentMenu();
            }
            catch (Exception scanError)
            {
                MelonLogger.Warning(
                    "[JondoAdminV5] Recherche AdminMenu existant ignoree : " +
                    scanError.Message
                );
            }

            if (IsValidMenu(menu))
            {
                CaptureMenu(menu);
                SetStatus("AdminMenu trouve. Chargement du XML Jondo...");
                return true;
            }

            SetStatus("Recherche des services internes Ankama...");

            Il2Cpp.ezp messageBus =
                FindService(typeof(Il2Cpp.ezp), "ezp/messageBus") as Il2Cpp.ezp;
            Il2Cpp.faa playerService =
                FindService(typeof(Il2Cpp.faa), "faa/playerService") as Il2Cpp.faa;
            Il2Cpp.eww commandService =
                FindService(typeof(Il2Cpp.eww), "eww/commandService") as Il2Cpp.eww;
            Il2Cpp.ewy configurationService =
                FindService(typeof(Il2Cpp.ewy), "ewy/configurationService") as Il2Cpp.ewy;

            var missing = new List<string>();
            if (!IsValidObject(messageBus)) missing.Add("ezp");
            if (!IsValidObject(playerService)) missing.Add("faa");
            if (!IsValidObject(commandService)) missing.Add("eww");
            if (!IsValidObject(configurationService)) missing.Add("ewy");

            if (missing.Count != 0)
            {
                SetStatus(
                    "AdminMenu non construit. Services introuvables : " +
                    string.Join(", ", missing)
                );
                return false;
            }

            try
            {
                menu = new AdminMenu(
                    messageBus,
                    playerService,
                    commandService,
                    configurationService
                );

                CaptureMenu(menu);

                try
                {
                    menu.OnStart();
                    MelonLogger.Msg("[JondoAdminV5] AdminMenu.OnStart execute.");
                }
                catch (Exception startError)
                {
                    MelonLogger.Warning(
                        "[JondoAdminV5] OnStart non bloquant : " +
                        startError.Message
                    );
                }

                SetStatus(
                    "AdminMenu Ankama construit. Chargement du XML Jondo..."
                );
                return true;
            }
            catch (Exception ex)
            {
                SetStatus("Construction AdminMenu impossible : " + ex.Message);
                MelonLogger.Error("[JondoAdminV5] " + ex);
                return false;
            }
        }

        private static AdminMenu CurrentMenu()
        {
            if (IsValidMenu(_capturedMenu))
                return _capturedMenu;

            try
            {
                FieldInfo originalField = AccessTools.Field(
                    typeof(JondoAdminTools),
                    "_officialMenu"
                );

                AdminMenu menu = originalField?.GetValue(null) as AdminMenu;
                if (IsValidMenu(menu))
                    return menu;
            }
            catch
            {
            }

            return FindStaticMenu();
        }

        private static bool IsValidMenu(AdminMenu menu)
        {
            return menu != null && menu.Pointer != IntPtr.Zero;
        }

        private static bool IsValidObject(object value)
        {
            if (value == null)
                return false;

            try
            {
                PropertyInfo pointerProperty = value.GetType().GetProperty(
                    "Pointer",
                    BindingFlags.Instance |
                    BindingFlags.Public |
                    BindingFlags.NonPublic
                );

                if (pointerProperty == null)
                    return true;

                object pointerValue = pointerProperty.GetValue(value, null);
                return pointerValue is IntPtr pointer &&
                       pointer != IntPtr.Zero;
            }
            catch
            {
                return false;
            }
        }

        private static object FindService(Type wanted, string label)
        {
            object found = FindStaticService(wanted, label);
            if (IsValidObject(found))
                return found;

            try
            {
                MonoBehaviour[] behaviours =
                    Resources.FindObjectsOfTypeAll<MonoBehaviour>();

                int count = behaviours == null ? 0 : behaviours.Length;

                for (int i = 0; i < count; i++)
                {
                    MonoBehaviour behaviour = behaviours[i];
                    if (behaviour == null || behaviour.Pointer == IntPtr.Zero)
                        continue;

                    Type holderType;
                    try { holderType = behaviour.GetType(); }
                    catch { continue; }

                    PropertyInfo[] properties;
                    try
                    {
                        properties = holderType.GetProperties(
                            BindingFlags.Instance |
                            BindingFlags.Public |
                            BindingFlags.NonPublic
                        );
                    }
                    catch
                    {
                        continue;
                    }

                    foreach (PropertyInfo property in properties)
                    {
                        if (!IsCompatibleProperty(wanted, property))
                            continue;

                        try
                        {
                            object value = property.GetValue(behaviour, null);

                            if (!IsValidObject(value))
                                continue;

                            MelonLogger.Msg(
                                "[JondoAdminV5] " + label + " trouve via " +
                                holderType.FullName + "." + property.Name
                            );
                            return value;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning(
                    "[JondoAdminV5] Scan Unity " + label + " : " + ex.Message
                );
            }

            MelonLogger.Warning(
                "[JondoAdminV5] Service absent : " + label
            );
            return null;
        }

        private static object FindStaticService(
            Type wanted,
            string label)
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (assembly == null ||
                    assembly.FullName == null ||
                    !assembly.FullName.StartsWith("Il2Cpp", StringComparison.Ordinal))
                    continue;

                Type[] types = SafeTypes(assembly);

                foreach (Type holderType in types)
                {
                    if (holderType == null)
                        continue;

                    FieldInfo[] fields;
                    try
                    {
                        fields = holderType.GetFields(
                            BindingFlags.Static |
                            BindingFlags.Public |
                            BindingFlags.NonPublic
                        );
                    }
                    catch
                    {
                        continue;
                    }

                    foreach (FieldInfo field in fields)
                    {
                        if (!IsCompatibleField(wanted, field))
                            continue;

                        try
                        {
                            object value = field.GetValue(null);

                            if (!IsValidObject(value))
                                continue;

                            MelonLogger.Msg(
                                "[JondoAdminV5] " + label + " trouve dans " +
                                holderType.FullName + "." + field.Name
                            );
                            return value;
                        }
                        catch
                        {
                        }
                    }

                    PropertyInfo[] properties;
                    try
                    {
                        properties = holderType.GetProperties(
                            BindingFlags.Static |
                            BindingFlags.Public |
                            BindingFlags.NonPublic
                        );
                    }
                    catch
                    {
                        continue;
                    }

                    foreach (PropertyInfo property in properties)
                    {
                        if (!IsCompatibleProperty(wanted, property))
                            continue;

                        try
                        {
                            object value = property.GetValue(null, null);

                            if (!IsValidObject(value))
                                continue;

                            MelonLogger.Msg(
                                "[JondoAdminV5] " + label + " trouve dans " +
                                holderType.FullName + "." + property.Name
                            );
                            return value;
                        }
                        catch
                        {
                        }
                    }
                }
            }

            return null;
        }

        private static bool IsCompatibleField(
            Type wanted,
            FieldInfo field)
        {
            try
            {
                return wanted != null &&
                       field != null &&
                       wanted.IsAssignableFrom(field.FieldType);
            }
            catch
            {
                return false;
            }
        }

        private static bool IsCompatibleProperty(
            Type wanted,
            PropertyInfo property)
        {
            try
            {
                return wanted != null &&
                       property != null &&
                       property.GetIndexParameters().Length == 0 &&
                       wanted.IsAssignableFrom(property.PropertyType);
            }
            catch
            {
                return false;
            }
        }

        private static Type[] SafeTypes(Assembly assembly)
        {
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException loadError)
            {
                return Array.FindAll(
                    loadError.Types,
                    loadedType => loadedType != null
                );
            }
            catch
            {
                return Array.Empty<Type>();
            }
        }

        private static AdminMenu FindStaticMenu()
        {
            object value = FindStaticService(
                typeof(AdminMenu),
                "AdminMenu"
            );
            return value as AdminMenu;
        }
    }

    [HarmonyPatch(
        typeof(JondoAdminTools),
        nameof(JondoAdminTools.ToggleQuantumConsole)
    )]
    public static class JondoQuantumConsoleV4Patch
    {
        public static bool Prefix()
        {
            JondoAdminRuntimeV4.ToggleQuantum();
            return false;
        }
    }

    [HarmonyPatch(
        typeof(JondoAdminTools),
        nameof(JondoAdminTools.LoadOfficialMenu)
    )]
    public static class JondoOfficialMenuLoadV4Patch
    {
        public static bool Prefix()
        {
            return JondoAdminRuntimeV4.PrepareOfficialMenu();
        }

        public static void Postfix()
        {
            try
            {
                FieldInfo statusField = AccessTools.Field(
                    typeof(JondoAdminTools),
                    "_status"
                );

                string status = statusField?.GetValue(null) as string;

                if (!string.IsNullOrWhiteSpace(status))
                    MelonLogger.Msg("[JondoAdminV4] Etat interne : " + status);
            }
            catch
            {
            }
        }
    }

    [HarmonyPatch]
    public static class JondoAdminMenuConstructorV4Patch
    {
        public static bool Prepare()
        {
            // Les constructeurs IL2CPP AdminMenu ne supportent pas ce patch.
            return false;
        }

        public static IEnumerable<MethodBase> TargetMethods()
        {
            foreach (ConstructorInfo constructor in
                AccessTools.GetDeclaredConstructors(typeof(AdminMenu)))
            {
                yield return constructor;
            }
        }

        public static void Postfix(AdminMenu __instance)
        {
            if (JondoFixMod.IsJondoAdministrator)
                JondoAdminRuntimeV4.CaptureMenu(__instance);
        }
    }
}

