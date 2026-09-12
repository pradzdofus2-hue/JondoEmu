using System;
using Il2CppInterop.Runtime;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace JondoFix
{
    public static class JondoAdminCanvas
    {
        private static GameObject _canvas;
        private static GameObject _panel;
        private static InputField _character;
        private static InputField _command;
        private static Text _status;
        private static Font _font;
        private static bool _creating;

        public static void Ensure()
        {
            if (!JondoFixMod.IsJondoAdministrator || _canvas != null || _creating)
                return;

            _creating = true;

            try
            {
                CreateInterface();
                MelonLogger.Msg("[JondoAdminCanvas] Canvas cree avec succes.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error("[JondoAdminCanvas] Creation impossible : " + ex);
                if (_canvas != null)
                    UnityEngine.Object.Destroy(_canvas);
                _canvas = null;
            }
            finally
            {
                _creating = false;
            }
        }

        private static void CreateInterface()
        {
            try
            {
                _font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            }
            catch
            {
                _font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            }

            _canvas = new GameObject("JondoAdminCanvas");
            UnityEngine.Object.DontDestroyOnLoad(_canvas);

            Canvas canvas = _canvas.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 32760;

            CanvasScaler scaler = _canvas.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);
            scaler.matchWidthOrHeight = 0.5f;

            _canvas.AddComponent<GraphicRaycaster>();

            Button toggle = CreateButton(
                _canvas.transform, "ADMIN", 20, -20, 125, 42,
                new Color(0.08f, 0.55f, 0.72f, 0.98f),
                TogglePanel
            );

            _panel = CreateBox(
                _canvas.transform,
                "JondoAdminPanel",
                20, -72, 570, 650,
                new Color(0.025f, 0.045f, 0.065f, 0.97f)
            );

            CreateText(_panel.transform, "JONDO ADMINISTRATION",
                20, -15, 530, 35, 23, TextAnchor.MiddleCenter,
                new Color(0.20f, 0.85f, 1f, 1f));

            CreateText(_panel.transform, "Nom exact du personnage connecte",
                20, -62, 530, 25, 15, TextAnchor.MiddleLeft, Color.white);

            _character = CreateInput(_panel.transform,
                "Nom du personnage", 20, -90, 530, 38);

            CreateText(_panel.transform, "Commande",
                20, -142, 530, 25, 15, TextAnchor.MiddleLeft, Color.white);

            _command = CreateInput(_panel.transform,
                ".packets 20", 20, -170, 395, 40);

            CreateButton(_panel.transform, "EXECUTER",
                425, -170, 125, 40,
                new Color(0.10f, 0.65f, 0.30f, 1f),
                ExecuteCommand);

            CreateText(_panel.transform,
                "Clique un modele, complete la commande puis EXECUTER",
                20, -220, 530, 25, 14, TextAnchor.MiddleLeft,
                new Color(0.75f, 0.80f, 0.85f, 1f));

            int y = -255;

            CreatePreset("KAMAS", ".kamas 100000", 20, y);
            CreatePreset("NIVEAU", ".level 200", 200, y);
            CreatePreset("TAILLE", ".size 100", 380, y);

            y -= 50;
            CreatePreset("OBJET", ".item 10784 1", 20, y);
            CreatePreset("PANOPLIE", ".itemset 1", 200, y);
            CreatePreset("BOUTIQUE", ".shop", 380, y, true);

            y -= 50;
            CreatePreset("MAP ID", ".teleport 191104002 321", 20, y);
            CreatePreset("COORDONNEES", ".relative 4 -18", 200, y);
            CreatePreset("PAQUETS", ".packets 20", 380, y, true);

            y -= 72;

            CreateButton(_panel.transform, "QUANTUM CONSOLE",
                20, y, 255, 42,
                new Color(0.38f, 0.20f, 0.65f, 1f),
                JondoAdminTools.ToggleQuantumConsole);

            CreateButton(_panel.transform, "MENU ANKAMA",
                295, y, 255, 42,
                new Color(0.72f, 0.38f, 0.08f, 1f),
                JondoAdminTools.LoadOfficialMenu);

            y -= 62;

            _status = CreateText(_panel.transform,
                "Interface Canvas active. Entre ton personnage.",
                20, y, 530, 72, 14, TextAnchor.UpperLeft,
                new Color(0.35f, 1f, 0.65f, 1f));

            CreateButton(_panel.transform, "MASQUER LE PANNEAU",
                150, -590, 270, 38,
                new Color(0.48f, 0.12f, 0.14f, 1f),
                TogglePanel);
        }

        private static void CreatePreset(
            string label, string command, float x, float y,
            bool executeImmediately = false)
        {
            CreateButton(_panel.transform, label, x, y, 170, 38,
                new Color(0.10f, 0.25f, 0.36f, 1f),
                () =>
                {
                    _command.text = command;

                    if (executeImmediately)
                        ExecuteCommand();
                    else
                        _command.ActivateInputField();
                });
        }

        private static void ExecuteCommand()
        {
            string character = _character?.text?.Trim() ?? "";
            string command = _command?.text?.Trim() ?? "";

            if (character.Length == 0)
            {
                SetStatus("Entre le NOM DU PERSONNAGE, pas le compte.");
                return;
            }

            if (command.Length == 0)
            {
                SetStatus("Entre une commande.");
                return;
            }

            JondoAdminTools.SetTargetCharacter(character);
            JondoAdminTools.SendCommand(command);

            SetStatus("Commande envoyee : " + command);
        }

        private static void TogglePanel()
        {
            if (_panel == null)
                return;

            _panel.SetActive(!_panel.activeSelf);
        }

        private static void SetStatus(string value)
        {
            if (_status != null)
                _status.text = value;

            MelonLogger.Msg("[JondoAdminCanvas] " + value);
        }

        private static GameObject CreateBox(
            Transform parent, string name,
            float x, float y, float width, float height, Color color)
        {
            GameObject go = new GameObject(name);
            go.transform.SetParent(parent, false);

            Image image = go.AddComponent<Image>();
            image.color = color;

            SetRect(image.rectTransform, x, y, width, height);
            return go;
        }

        private static Text CreateText(
            Transform parent, string value,
            float x, float y, float width, float height,
            int size, TextAnchor alignment, Color color)
        {
            GameObject go = new GameObject("Text");
            go.transform.SetParent(parent, false);

            Text text = go.AddComponent<Text>();
            text.font = _font;
            text.fontSize = size;
            text.alignment = alignment;
            text.color = color;
            text.text = value;
            text.horizontalOverflow = HorizontalWrapMode.Wrap;
            text.verticalOverflow = VerticalWrapMode.Truncate;

            SetRect(text.rectTransform, x, y, width, height);
            return text;
        }

        private static InputField CreateInput(
            Transform parent, string initialValue,
            float x, float y, float width, float height)
        {
            GameObject go = CreateBox(parent, "InputField",
                x, y, width, height,
                new Color(0.10f, 0.13f, 0.17f, 1f));

            InputField input = go.AddComponent<InputField>();

            Text text = CreateText(go.transform, initialValue,
                10, -4, width - 20, height - 8,
                16, TextAnchor.MiddleLeft, Color.white);

            input.textComponent = text;
            input.text = initialValue;
            input.lineType = InputField.LineType.SingleLine;
            input.contentType = InputField.ContentType.Standard;
            input.targetGraphic = go.GetComponent<Image>();

            return input;
        }

        private static Button CreateButton(
            Transform parent, string label,
            float x, float y, float width, float height,
            Color color, Action callback)
        {
            GameObject go = CreateBox(parent, "Button_" + label,
                x, y, width, height, color);

            Button button = go.AddComponent<Button>();
            button.targetGraphic = go.GetComponent<Image>();

            CreateText(go.transform, label,
                4, -2, width - 8, height - 4,
                14, TextAnchor.MiddleCenter, Color.white);

            UnityAction action =
                DelegateSupport.ConvertDelegate<UnityAction>(callback);

            button.onClick.AddListener(action);
            return button;
        }

        private static void SetRect(
            RectTransform rect,
            float x, float y, float width, float height)
        {
            rect.anchorMin = new Vector2(0f, 1f);
            rect.anchorMax = new Vector2(0f, 1f);
            rect.pivot = new Vector2(0f, 1f);
            rect.anchoredPosition = new Vector2(x, y);
            rect.sizeDelta = new Vector2(width, height);
        }
    }
}
