using CyberCAT.Core;
using CyberCAT.Core.Classes;
using IronPython.Hosting;
using MahApps.Metro.Controls;
using Microsoft.Scripting.Hosting;
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
            Click += ScriptTile_Click;
            Content = action.DisplayName;
            ToolTip = action.Description;
        }

        private void ScriptTile_Click(object sender, System.Windows.RoutedEventArgs e)
        {
                _action.Execute(_saveFile, _folderPath);
                _ = notificationManager.ShowAsync(
                new NotificationContent { Title = _action.DisplayName, Message = _action.SuccessMessage, Type = NotificationType.Success, },
                areaName: "WindowArea", TimeSpan.FromSeconds(2));

        }
    }
}
