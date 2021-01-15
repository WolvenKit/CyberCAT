using CyberCAT.Core;
using CyberCAT.Core.Classes;
using IronPython.Hosting;
using MahApps.Metro.Controls;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

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
            ToolTip = action.Description;
        }

        private void ScriptTile_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                _action.Execute(_saveFile);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Executing QuickAction {_action.DisplayName}: {ex.Message}");
            }
        }
    }
}
