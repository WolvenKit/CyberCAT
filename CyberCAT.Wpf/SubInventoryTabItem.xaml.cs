using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CyberCAT.Core;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Wpf.Classes;
using MahApps.Metro.Controls;

namespace CyberCAT.Wpf
{
    /// <summary>
    /// Interaktionslogik für SubInventoryViewer.xaml
    /// </summary>
    public partial class SubInventoryTabItem : MetroTabItem
    {
        public SaveFile SaveFile { get; }

        private Inventory.SubInventory ThisInventory { get; }

        private static readonly Dictionary<ulong, string> InventoryNames = new()
        {
            { 0x1, "V's Bag" },
            { 0xF4240, "Car Stash" },
            { 0x895724, "Nomad Intro Items" },
            { 0x895956, "Street Kid Intro Items" },
            { 0x8959E8, "Corpo Intro Items" },
            { 0x38E8D0C9F9A087AE, "Panam's Stash" },
            { 0x6E48C594562422DE, "Judy's Stash" },
            { 0x7901DE03D136A5AF, "V's Wardrobe" },
            { 0xE5F556FCBB62A706, "V's Stash" },
            { 0xEDAD8C9B086A615E, "River's Stash" },
        };

        public SubInventoryTabItem(Inventory.SubInventory subInventory, SaveFile saveFile)
        {
            ThisInventory = subInventory;
            SaveFile = saveFile;
            InitializeComponent();

            var inventories = saveFile.GetInventory().SubInventories;
            foreach (var si in inventories)
            {
                if (si == ThisInventory)
                {
                    continue;
                }
                var mi = new MenuItem {
                    Header = new TextBlock
                    {
                        Text = InventoryNames.TryGetValue(si.InventoryId, out var siName) ? siName : $"{si.InventoryId:X}"
                    },
                    Tag = si,
                };
                mi.Click += OnMoveToInventoryClicked;
                MoveToMenu.Items.Add(mi);
            }

            Header = InventoryNames.TryGetValue(subInventory.InventoryId, out var name) ? name : $"{subInventory.InventoryId:X}";
            Items.ItemsSource = subInventory.Items;
            var itemsView = CollectionViewSource.GetDefaultView(Items.ItemsSource);
            Items.DisplayMemberPath = "ItemGameNameOrName";
            itemsView.Filter = FilterItems;
        }

        private bool FilterItems(object item)
        {
            if (string.IsNullOrWhiteSpace(Search.Text))
            {
                return true;
            }
            // We use ToString here as it includes both the Name (e.g., Items.money) as well as the GameName (Eddies)
            return (item as ItemData)?.ToString().IndexOf(Search.Text, StringComparison.InvariantCultureIgnoreCase) >= 0;
        }

        private void ItemsSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(Items.ItemsSource).Refresh();
        }

        private void SelectedItemChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemEditor.Item = (ItemData)Items.SelectedItem;
        }

        private void OnMoveToInventoryClicked(object sender, RoutedEventArgs e)
        {
            var targetInventory = (Inventory.SubInventory)((MenuItem)sender).Tag;
            var item = (ItemData)Items.SelectedItem;
            ThisInventory.Items.Remove(item);
            targetInventory.Items.Add(item);
        }
    }
}
