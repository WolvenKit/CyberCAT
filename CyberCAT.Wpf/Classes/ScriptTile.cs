using CyberCAT.Core;
using CyberCAT.Core.Classes;
using MahApps.Metro.Controls;
using Notifications.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace CyberCAT.Wpf.Classes
{
    class ScriptTile : Tile
    {
        static NotificationManager notificationManager = new NotificationManager();
        private QuickAction _action;
        private SaveFile _saveFile;
        private string _folderPath;
        public ScriptTile(QuickAction action, SaveFile saveFile, string folderPath)
        {
            _action = action;
            _saveFile = saveFile;
            _folderPath = folderPath;
            Content = action.DisplayName;
            ToolTip = action.Description;
        }
        public void RunScript(bool debuggingEnabled, int debugPort)
        {
            try
            {
                _action.Execute(_saveFile, _folderPath, debuggingEnabled, debugPort);
                _ = notificationManager.ShowAsync(
                new NotificationContent { Title = _action.DisplayName, Message = _action.SuccessMessage, Type = NotificationType.Success, },
                areaName: "WindowArea", TimeSpan.FromSeconds(2));
            }
            catch(Exception ex)
            {
                _ = notificationManager.ShowAsync(
                new NotificationContent { Title = _action.DisplayName, Message = "Error executing action. More info in Messagebox", Type = NotificationType.Error, },
                areaName: "WindowArea", TimeSpan.FromSeconds(4));
                MessageBox.Show($"Error Executing Action {_action.DisplayName}: {ex.Message}");
            }
        }
    }
}
