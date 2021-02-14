using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.Parsers;
using CyberCAT.Wpf.Common.Classes;
using MahApps.Metro.Controls;

namespace CyberCAT.Wpf.Common
{
    public partial class SettingsWindow : MetroWindow
    {
        private readonly Settings _originalSettings;

        public Settings NewSettings { get; private set; }

        private Settings CurrentSettings
        {
            get
            {
                var settings = new Settings();

                if (OpenInSavedGames.IsChecked != null)
                {
                    settings.StartInSavesFolder = OpenInSavedGames.IsChecked.Value;
                }
                if (AllowQuickActions.IsChecked != null)
                {
                    settings.AllowQuickActions = AllowQuickActions.IsChecked.Value;
                }
                if (EnableQuickActionDebugging.IsChecked != null)
                {
                    settings.EnableQuickActionDebugging = EnableQuickActionDebugging.IsChecked.Value;
                }
                if (QuickActionDebuggingPort.Value.HasValue)
                {
                    settings.QuickActionDebuggingPort = (int)QuickActionDebuggingPort.Value;
                }
                if (ParsersSimple.IsChecked != null && ParsersSimple.IsChecked.Value)
                {
                    settings.EnabledParsers = SaveFile.ParserList.Simple;
                }
                else if (ParsersEnhanced.IsChecked != null && ParsersEnhanced.IsChecked.Value)
                {
                    settings.EnabledParsers = SaveFile.ParserList.Enhanced;
                }
                else if (ParsersAll.IsChecked != null && ParsersAll.IsChecked.Value)
                {
                    settings.EnabledParsers = SaveFile.ParserList.All;
                }

                return settings;
            }
        }

        public SettingsWindow(Settings settings)
        {
            _originalSettings = settings;
            InitializeComponent();
            OpenInSavedGames.IsChecked = settings.StartInSavesFolder;
            AllowQuickActions.IsChecked = settings.AllowQuickActions;
            EnableQuickActionDebugging.IsChecked = settings.EnableQuickActionDebugging;
            QuickActionDebuggingPort.Value = settings.QuickActionDebuggingPort;
            switch (settings.EnabledParsers)
            {
                case SaveFile.ParserList.Simple:
                    ParsersSimple.IsChecked = true;
                    ParsersEnhanced.IsChecked = false;
                    ParsersAll.IsChecked = false;
                    break;
                case SaveFile.ParserList.Enhanced:
                    ParsersSimple.IsChecked = false;
                    ParsersEnhanced.IsChecked = true;
                    ParsersAll.IsChecked = false;
                    break;
                case SaveFile.ParserList.All:
                    ParsersSimple.IsChecked = false;
                    ParsersEnhanced.IsChecked = false;
                    ParsersAll.IsChecked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnClosed(object sender, EventArgs e)
        {
            NewSettings ??= _originalSettings;
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            NewSettings = _originalSettings;
            Close();
        }

        private void OnDefaultsClick(object sender, RoutedEventArgs e)
        {
            NewSettings = Settings.Default;
            QuickAction.ResetEngine();
            Close();
        }

        private void OnSaveClick(object sender, RoutedEventArgs e)
        {
            NewSettings = CurrentSettings;
            QuickAction.ResetEngine();
            Close();
        }

        private void OnParserTooltipMouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void OnParserTooltipMouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
