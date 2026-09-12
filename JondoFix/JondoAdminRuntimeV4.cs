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
            AdminMenu menu = _capturedMenu;

            if (menu == null || menu.Pointer == IntPtr.Zero)
            {
                try
                {
                    FieldInfo originalField = AccessTools.Field(
                        typeof(JondoAdminTools),
                        "_officialMenu"
                    );

                    menu = originalField?.GetValue(null) as AdminMenu;
                }
                catch
                {
                    menu = null;
                }
            }

            if ((menu == null || menu.Pointer == IntPtr.Zero) &&
                !_menuScanDone)
            {
                _menuScanDone = true;
                menu = FindStaticMenu();
            }

            if (menu == null || menu.Pointer == IntPtr.Zero)
            {
                SetStatus(
                    "AdminMenu Ankama absent : le client normal ne l'a pas instancie."
                );
                return false;
            }

            CaptureMenu(menu);
            SetStatus("AdminMenu trouve. Chargement du XML Jondo...");
            return true;
        }

        private static AdminMenu FindStaticMenu()
        {
            try
            {
                Type menuType = typeof(AdminMenu);
                Type[] types;

                try
                {
                    types = menuType.Assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException loadError)
                {
                    types = Array.FindAll(
                        loadError.Types,
                        loadedType => loadedType != null
                    );

                    MelonLogger.Warning(
                        "[JondoAdminV4] Certains types IL2CPP sont invalides, scan poursuivi sur " +
                        types.Length + " types valides."
                    );
                }

                foreach (Type type in types)
                {
                    FieldInfo[] fields = type.GetFields(
                        BindingFlags.Static |
                        BindingFlags.Public |
                        BindingFlags.NonPublic
                    );

                    foreach (FieldInfo field in fields)
                    {
                        if (!menuType.IsAssignableFrom(field.FieldType))
                            continue;

                        try
                        {
                            AdminMenu menu = field.GetValue(null) as AdminMenu;

                            if (menu != null && menu.Pointer != IntPtr.Zero)
                            {
                                MelonLogger.Msg(
                                    "[JondoAdminV4] AdminMenu trouve dans " +
                                    type.FullName + "." + field.Name
                                );
                                return menu;
                            }
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
                    "[JondoAdminV4] Scan AdminMenu : " + ex.Message
                );
            }

            return null;
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

