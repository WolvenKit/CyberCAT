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
using MahApps.Metro.Controls;
using Microsoft.Win32;
using Newtonsoft.Json;
using Path = System.IO.Path;
using System.ComponentModel;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Core.Classes.Interfaces;
using System.Windows.Forms;
using CyberCAT.Core;
using CyberCAT.Wpf.Classes;

namespace CyberCAT.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private SaveFile LoadedSaveFile { get; set; }
        private System.Windows.Forms.PropertyGrid _propertyGrid;
        private const string NAMES_FILE_NAME = "Names.json";
        public MainWindow()
        {
            InitializeComponent();
            _propertyGrid = new PropertyGrid();
            AddTypeDescriptorAttributes();
            ApplyStyleToPropertyGrid();
            
            System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            host.Child = _propertyGrid;
            
            


            propertyGridHost.Children.Add(host);
            if (File.Exists(NAMES_FILE_NAME))
            {
                NameResolver.UseDictionary(JsonConvert.DeserializeObject<Dictionary<ulong, NameResolver.NameStruct>>(File.ReadAllText(NAMES_FILE_NAME)));
            }
        }
        private void ApplyStyleToPropertyGrid()
        {
            var mergedDictionaries = ThemeManager.Current.DetectTheme(System.Windows.Application.Current).Resources.MergedDictionaries[0].MergedDictionaries[0];
            var textColorBrush = (SolidColorBrush)mergedDictionaries["MahApps.Brushes.Text"];
            var textColor = System.Drawing.Color.FromArgb(textColorBrush.Color.A, textColorBrush.Color.R, textColorBrush.Color.G, textColorBrush.Color.B);
            var accentBrush = (SolidColorBrush)mergedDictionaries["MahApps.Brushes.Accent"];
            var accentColor = System.Drawing.Color.FromArgb(accentBrush.Color.A, accentBrush.Color.R, accentBrush.Color.G, accentBrush.Color.B);
            var backGroundBrush = (SolidColorBrush)mergedDictionaries["MahApps.Brushes.Window.Background"];
            var backColor = System.Drawing.Color.FromArgb(backGroundBrush.Color.A, backGroundBrush.Color.R, backGroundBrush.Color.G, backGroundBrush.Color.B);


            _propertyGrid.ViewBackColor = backColor;
            _propertyGrid.HelpBackColor = backColor;
            _propertyGrid.BackColor = backColor;

            _propertyGrid.LineColor = accentColor;
            _propertyGrid.SelectedItemWithFocusBackColor = accentColor;
            _propertyGrid.HelpBorderColor = accentColor;
            _propertyGrid.CategorySplitterColor = accentColor;
            _propertyGrid.ViewBorderColor = accentColor;

            _propertyGrid.SelectedItemWithFocusForeColor = textColor;
            _propertyGrid.HelpForeColor = textColor;
            _propertyGrid.CategoryForeColor = textColor;
            _propertyGrid.ViewForeColor = textColor;
        }
        private void AddTypeDescriptorAttributes()
        {
            TypeDescriptor.AddAttributes(typeof(CharacterCustomizationAppearances.AppearanceSection), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CharacterCustomizationAppearances.Section), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.NextItemEntry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ItemFlags), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.HeaderThing), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ItemInnerData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.SimpleItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ModableItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ItemModData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Inventory.SubInventory), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemDropStorage), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FactsTable.FactEntry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(TweakDbId), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(GenericUnknownStruct.BaseClassEntry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IHandle), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(List<NodeRepresentation>), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private static string OpenSaveFileDialog(bool startInSaveFolder)
        {
            var fd = new Microsoft.Win32.OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };
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
            var saveDialog = new Microsoft.Win32.SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };
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
                System.Windows.MessageBox.Show($"Error reading file: {exception.Message}");
                return;
            }

            InitializeEditors();
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
                System.Windows.MessageBox.Show($"Error reading file: {exception.Message}");
                return;
            }

            InitializeEditors();
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

        private void InitializeEditors()
        {
            SimpleItemsTab.Content = new InventoryViewer(LoadedSaveFile);
            foreach (var node in LoadedSaveFile.Nodes)
            {
                var treeNode = new SaveNodeTreeViewItem(node);
                BuildVisualSubTree(treeNode, null);
                advancedTabTreeView.Items.Add(treeNode);
            }
        }
        private void BuildVisualSubTree(SaveNodeTreeViewItem treeNode, string filter)
        {
            if (treeNode.Node.Value is Inventory inv)
            {
                // For inventory, we insert virtual nodes for the sub inventories.
                var subinventories = inv.SubInventories.Select(_ => (NodeEntry)new VirtualNodeEntry() { Value = _ }).ToList();
                foreach (var subinventory in subinventories)
                {
                    var real = subinventory as VirtualNodeEntry ?? throw new Exception("subinventory is not a VirtualNodeEntry, wtf?!");
                    var data = real.Value as Inventory.SubInventory;
                    var simpleItems = new VirtualNodeEntry { Value = "Simple items" };
                    var modableItems = new VirtualNodeEntry { Value = "Modable Items" };
                    foreach (var itemNode in treeNode.Node.Children)
                    {
                        if (data.Items.Contains(itemNode.Value) && (filter == null || itemNode.ToString().ToLowerInvariant().Contains(filter)))
                        {
                            var item = ((ItemData)itemNode.Value).Data;
                            if (item is ItemData.SimpleItemData sid)
                            {
                                simpleItems.Children.Add(itemNode);
                            }
                            else
                            {
                                modableItems.Children.Add(itemNode);
                            }
                        }
                    }
                    if (simpleItems.Children.Count > 0)
                    {
                        subinventory.Children.Add(simpleItems);
                    }
                    if (modableItems.Children.Count > 0)
                    {
                        subinventory.Children.Add(modableItems);
                    }
                }
                foreach (var item in SaveNodeTreeViewItem.FromList(subinventories.Where(_ => filter == null || _.Children.Count > 0).ToList()).ToArray())
                { treeNode.Items.Add(item); }
                foreach (var child in treeNode.Items)
                {
                    BuildVisualSubTree((SaveNodeTreeViewItem)child, filter);
                }

                return;
            }
        }

        private void advancedTabTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _propertyGrid.SelectedObject = ((SaveNodeTreeViewItem)advancedTabTreeView.SelectedItem).Node.Value;
        }
    }
}
