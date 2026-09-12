using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HarmonyLib;
using Il2CppCore.UILogic.Admin;
using Il2CppQFSW.QC;
using MelonLoader;
using UnityEngine;

namespace JondoFix
{
    /// <summary>
    /// Outils d'administration visibles uniquement lorsque le launcher a transmis un rÃ´le 5.
    /// Toutes les opÃ©rations sensibles repassent par l'API locale et sont revÃ©rifiÃ©es par le serveur.
    /// </summary>
    public static class JondoAdminTools
    {
        private static readonly HttpClient Http = new HttpClient { Timeout = TimeSpan.FromSeconds(8) };
        private static Rect _window = new Rect(35, 70, 540, 650);
        private static bool _visible = true;
        private static bool _busy;
        private static string _status = "PrÃªt â€” F8 console, F9 panneau, F10 menu Ankama";
        private static string _character = "";

        public static void SetTargetCharacter(string character)
        {
            _character = character ?? "";
        }
        private static string _rawCommand = ".packets 10";
        private static string _kamas = "100000";
        private static string _level = "200";
        private static string _size = "100";
        private static string _item = "10784";
        private static string _quantity = "1";
        private static string _set = "1";
        private static string _map = "191104002";
        private static string _cell = "321";
        private static string _x = "4";
        private static string _y = "-18";
        private static Vector2 _scroll;
        private static AdminMenu _officialMenu;
        private static bool _officialMenuLoaded;
        private static bool _runtimeLogged;
        private static bool _f8WasDown;
        private static bool _f9WasDown;
        private static bool _f10WasDown;

        private const int VkF8 = 0x77;
        private const int VkF9 = 0x78;
        private const int VkF10 = 0x79;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int virtualKey);

        private static string Token => Environment.GetEnvironmentVariable("JONDO_ADMIN_TOKEN") ?? "";

        public static void Update()
        {
            if (!JondoFixMod.IsJondoAdministrator) return;

            JondoAdminCanvas.Ensure();

            if (!_runtimeLogged)
            {
                _runtimeLogged = true;
                MelonLogger.Msg("[JondoAdmin] Runtime actif â€” F8 console, F9 panneau, F10 menu Ankama.");
                MelonLogger.Msg("[JondoAdmin] Token launcher prÃ©sent : " + (!string.IsNullOrEmpty(Token)));
                MelonLogger.Msg("[JondoAdmin] Racine Ã©mulateur : " + JondoFixMod.EmulatorRoot);
            }

            if (Pressed(VkF8, ref _f8WasDown)) ToggleQuantumConsole();
            if (Pressed(VkF9, ref _f9WasDown))
            {
                _visible = !_visible;
                if (_visible) Cursor.visible = true;
                MelonLogger.Msg("[JondoAdmin] Panneau F9 : " + (_visible ? "ouvert" : "fermÃ©"));
            }
            if (Pressed(VkF10, ref _f10WasDown)) LoadOfficialMenu();
        }

        private static bool Pressed(int virtualKey, ref bool wasDown)
        {
            bool down = (GetAsyncKeyState(virtualKey) & 0x8000) != 0;
            bool pressed = down && !wasDown;
            wasDown = down;
            return pressed;
        }

        public static void Draw()
        {
            if (!JondoFixMod.IsJondoAdministrator || !_visible) return;
            _window = GUILayout.Window(927451, _window, (GUI.WindowFunction)DrawWindow,
                                       "JondoEmu â€” Administration");
        }

        private static void DrawWindow(int id)
        {
            _scroll = GUILayout.BeginScrollView(_scroll, GUILayout.Height(590));

            GUILayout.Label("Personnage connectÃ© ciblÃ©");
            _character = GUILayout.TextField(_character ?? "");
            GUILayout.Label("Le nom du personnage est obligatoire, pas le nom du compte.");

            GUILayout.Space(8);
            GUILayout.Label("Commande libre");
            GUILayout.BeginHorizontal();
            _rawCommand = GUILayout.TextField(_rawCommand ?? "");
            if (GUILayout.Button("ExÃ©cuter", GUILayout.Width(105))) SendCommand(_rawCommand);
            GUILayout.EndHorizontal();

            GUILayout.Space(8);
            GUILayout.Label("Personnage");
            CommandLine("Kamas +/-", ref _kamas, ".kamas", "Appliquer");
            CommandLine("Niveau", ref _level, ".level", "Appliquer");
            CommandLine("Taille (100 normal)", ref _size, ".size", "Appliquer");

            GUILayout.BeginHorizontal();
            GUILayout.Label("Objet", GUILayout.Width(150));
            _item = GUILayout.TextField(_item, GUILayout.Width(105));
            GUILayout.Label("QtÃ©", GUILayout.Width(28));
            _quantity = GUILayout.TextField(_quantity, GUILayout.Width(65));
            if (GUILayout.Button("Donner")) SendCommand($".item {_item} {_quantity}");
            GUILayout.EndHorizontal();

            CommandLine("Panoplie", ref _set, ".itemset", "Donner");

            GUILayout.Space(8);
            GUILayout.Label("DÃ©placements");
            GUILayout.BeginHorizontal();
            GUILayout.Label("Map ID", GUILayout.Width(150));
            _map = GUILayout.TextField(_map, GUILayout.Width(130));
            GUILayout.Label("Cell", GUILayout.Width(35));
            _cell = GUILayout.TextField(_cell, GUILayout.Width(65));
            if (GUILayout.Button("TÃ©lÃ©porter")) SendCommand($".teleport {_map} {_cell}");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("CoordonnÃ©es", GUILayout.Width(150));
            _x = GUILayout.TextField(_x, GUILayout.Width(70));
            _y = GUILayout.TextField(_y, GUILayout.Width(70));
            if (GUILayout.Button("Aller en X/Y")) SendCommand($".relative {_x} {_y}");
            GUILayout.EndHorizontal();

            GUILayout.Space(8);
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Ouvrir boutique")) SendCommand(".shop");
            if (GUILayout.Button("Paquets inconnus")) SendCommand(".packets 20");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Console dÃ©veloppeur (F8)")) ToggleQuantumConsole();
            if (GUILayout.Button("Recharger menu Ankama (F10)")) LoadOfficialMenu();
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.Label(_busy ? "Envoi en coursâ€¦" : _status);
            if (string.IsNullOrEmpty(Token))
                GUILayout.Label("ERREUR : JONDO_ADMIN_TOKEN absent. Recompile aussi le launcher.");

            GUILayout.EndScrollView();
            GUI.DragWindow(new Rect(0, 0, 10000, 28));
        }

        private static void CommandLine(string label, ref string value, string command, string button)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(label, GUILayout.Width(150));
            value = GUILayout.TextField(value ?? "");
            if (GUILayout.Button(button, GUILayout.Width(105))) SendCommand(command + " " + value);
            GUILayout.EndHorizontal();
        }

        public static void SendCommand(string command)
        {
            command = (command ?? "").Trim();
            if (_busy) { _status = "Une commande est dÃ©jÃ  en cours."; return; }
            if (string.IsNullOrWhiteSpace(_character)) { _status = "Entre d'abord le nom du personnage."; return; }
            if (string.IsNullOrWhiteSpace(Token)) { _status = "Token absent : recompile et relance le launcher."; return; }
            if (!command.StartsWith(".", StringComparison.Ordinal)) command = "." + command;

            _busy = true;
            _status = "Envoi de " + command;
            _ = PostAsync("commande", new Dictionary<string, object>
            {
                ["token"] = Token,
                ["personaje"] = _character.Trim(),
                ["comando"] = command,
            });
        }

        private static async Task PostAsync(string route, object body)
        {
            try
            {
                string json = JsonSerializer.Serialize(body);
                using var content = new StringContent(json, Encoding.UTF8, "application/json");
                using HttpResponseMessage response = await Http.PostAsync("http://127.0.0.1:8888/api/" + route, content);
                string answer = await response.Content.ReadAsStringAsync();
                _status = response.IsSuccessStatusCode
                    ? "OK : " + answer
                    : $"Erreur HTTP {(int)response.StatusCode} : {answer}";
            }
            catch (Exception ex)
            {
                _status = "Erreur API : " + ex.Message;
            }
            finally { _busy = false; }
        }

        public static void ToggleQuantumConsole()
        {
            try
            {
                QuantumConsole console = QuantumConsole.Instance;
                if (console == null || console.Pointer == IntPtr.Zero)
                {
                    _status = "QuantumConsole existe dans le code mais aucune instance n'est chargÃ©e dans cette scÃ¨ne.";
                    MelonLogger.Warning("[JondoAdmin] QuantumConsole.Instance est null.");
                    return;
                }
                console.Toggle();
                _status = "QuantumConsole : " + (console.IsActive ? "ouverte" : "fermÃ©e");
            }
            catch (Exception ex)
            {
                _status = "QuantumConsole : " + ex.Message;
                MelonLogger.Error("[JondoAdmin] " + ex);
            }
        }

        public static void CaptureOfficialMenu(AdminMenu menu)
        {
            if (menu == null || menu.Pointer == IntPtr.Zero) return;
            _officialMenu = menu;
            try
            {
                menu.m_rank = 5;
                menu.m_hierarchyString = "5";
            }
            catch (Exception ex) { MelonLogger.Warning("[JondoAdmin] Rang officiel : " + ex.Message); }
        }

        public static void LoadOfficialMenu()
        {
            if (!JondoFixMod.IsJondoAdministrator) return;

            JondoAdminCanvas.Ensure();
            if (_officialMenu == null || _officialMenu.Pointer == IntPtr.Zero)
            {
                _status = "AdminMenu officiel pas encore crÃ©Ã©. Entre dans le monde puis rÃ©essaie F10.";
                return;
            }
            try
            {
                string path = System.IO.Path.Combine(JondoFixMod.EmulatorRoot, "datos", "menuadmin_jondo.xml");
                if (!System.IO.File.Exists(path))
                {
                    _status = "XML introuvable : " + path;
                    return;
                }
                var xml = new Il2CppSystem.Xml.XmlDocument();
                xml.Load(path);
                _officialMenu.m_rank = 5;
                _officialMenu.m_hierarchyString = "5";
                _officialMenu.OnFileLoaded(xml);
                _officialMenuLoaded = true;
                _status = "Menu Ankama Jondo chargÃ©. Fais un clic droit sur un personnage.";
                MelonLogger.Msg("[JondoAdmin] menuadmin_jondo.xml chargÃ©.");
            }
            catch (Exception ex)
            {
                _status = "Chargement AdminMenu : " + ex.Message;
                MelonLogger.Error("[JondoAdmin] " + ex);
            }
        }
    }

    [HarmonyPatch(typeof(AdminMenu), nameof(AdminMenu.OnStart))]
    public static class JondoOfficialAdminMenuStartPatch
    {
        public static void Prefix(AdminMenu __instance)
        {
            if (JondoFixMod.IsJondoAdministrator) JondoAdminTools.CaptureOfficialMenu(__instance);
        }

        public static void Postfix(AdminMenu __instance)
        {
            if (!JondoFixMod.IsJondoAdministrator) return;

            JondoAdminCanvas.Ensure();
            JondoAdminTools.CaptureOfficialMenu(__instance);
            JondoAdminTools.LoadOfficialMenu();
        }
    }
}


