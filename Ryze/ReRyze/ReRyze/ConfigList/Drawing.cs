﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace ReRyze.ConfigList
{
    public static class Drawing
    {
        private static readonly Menu Menu;
        private static readonly CheckBox _drawQ;
        private static readonly CheckBox _drawW;
        private static readonly CheckBox _drawE;
        private static readonly CheckBox _drawR;
        private static readonly CheckBox _drawDI;

        public static bool DrawQ
        {
            get { return _drawQ.CurrentValue; }
        }

        public static bool DrawW
        {
            get { return _drawW.CurrentValue; }
        }

        public static bool DrawE
        {
            get { return _drawE.CurrentValue; }
        }

        public static bool DrawR
        {
            get { return _drawR.CurrentValue; }
        }

        public static bool DrawDI
        {
            get { return _drawDI.CurrentValue; }
        }

        static Drawing()
        {
            Menu = Config.Menu.AddSubMenu("Drawing");
            Menu.AddGroupLabel("Gösterge Ayarları");
            _drawQ = Menu.Add("DrawQ", new CheckBox("Q Menzilini Göster"));
            _drawW = Menu.Add("DrawW", new CheckBox("W Menzilini Göster"));
            _drawE = Menu.Add("DrawE", new CheckBox("E Menzilini Göster"));
            _drawR = Menu.Add("DrawR", new CheckBox("R Menzilini Göster"));
            Menu.AddGroupLabel("Hasar Tespitçisi");
            _drawDI = Menu.Add("DrawDI", new CheckBox("Hasar Tespitçisini göster"));
        }

        public static void Initialize()
        {
        }
    }
}