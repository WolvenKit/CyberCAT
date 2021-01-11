using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using CyberCAT.Core.Classes;
using Microsoft.Win32;
using Path = System.IO.Path;

namespace CyberCAT.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SaveFile LoadedSaveFile { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private static string OpenSaveFileDialog(bool startInSaveFolder)
        {
            var fd = new OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };

            if (startInSaveFolder)
            {
                fd.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved games", "CD Projekt Red", "Cyberpunk 2077");
            }

            var result = fd.ShowDialog();
            if (!result.HasValue || result.Value == false)
            {
                return null;
            }

            return fd.FileName;
        }

        private static string SaveSaveFileDialog(bool startInSaveFolder)
        {
            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };
            if (startInSaveFolder)
            {
                saveDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved games", "CD Projekt Red", "Cyberpunk 2077");
            }

            var result = saveDialog.ShowDialog();

            if (!result.HasValue || !result.Value)
            {
                return null;
            }

            return saveDialog.FileName;
        }

        private void OpenPcOnClick(object sender, RoutedEventArgs e)
        {
            var fileName = OpenSaveFileDialog(true); // FIXME: get from settings
            if (fileName == null)
            {
                return;
            }

            try
            {
                var bytes = File.ReadAllBytes(fileName);
                //var newSaveFile = new SaveFile(_parserConfig.Where(p => p.Enabled).Select(p => p.Parser));
                var newSaveFile = new SaveFile();
                newSaveFile.LoadPCSaveFile(new MemoryStream(bytes));
                LoadedSaveFile = newSaveFile;
                Footer.Content = $"{LoadedSaveFile.Header} - {fileName}";
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error reading file: {exception.Message}");
            }
        }

        private void OpenPs4OnClick(object sender, RoutedEventArgs e)
        {
            var fileName = OpenSaveFileDialog(false);
            if (fileName == null)
            {
                return;
            }

            try
            {
                var bytes = File.ReadAllBytes(fileName);
                //var newSaveFile = new SaveFile(_parserConfig.Where(p => p.Enabled).Select(p => p.Parser));
                var newSaveFile = new SaveFile();
                newSaveFile.LoadPS4SaveFile(new MemoryStream(bytes));
                LoadedSaveFile = newSaveFile;
                Footer.Content = $"{LoadedSaveFile.Header} - {fileName}";
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error reading file: {exception.Message}");
            }
        }

        private void SavePcOnClick(object sender, RoutedEventArgs e)
        {
            var fileName = SaveSaveFileDialog(true); // FIXME: get from settings

            if (fileName != null)
            {
                File.WriteAllBytes(fileName, LoadedSaveFile.SaveToPCSaveFile());
            }
        }

        private void SavePs4OnClick(object sender, RoutedEventArgs e)
        {
            var fileName = SaveSaveFileDialog(true); // FIXME: get from settings

            if (fileName != null)
            {
                File.WriteAllBytes(fileName, LoadedSaveFile.SaveToPS4SaveFile());
            }
        }
    }
}
