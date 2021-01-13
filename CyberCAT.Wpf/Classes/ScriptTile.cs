using CyberCAT.Core.Classes;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberCAT.Wpf.Classes
{
    class ScriptTile : Tile
    {
        private QuickAction _action;
        private SaveFile _saveFile;
        public ScriptTile(QuickAction action, SaveFile saveFile)
        {
            _action = action;
            _saveFile = saveFile;
            Click += ScriptTile_Click;
            Content = action.DisplayName;
        }

        private void ScriptTile_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _action.Execute(_saveFile);
        }
    }
}
