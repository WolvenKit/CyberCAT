using System;
using System.Collections.Generic;
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
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;
using MahApps.Metro.Controls;

namespace CyberCAT.Wpf
{
    /// <summary>
    /// Interaktionslogik für SubInventoryViewer.xaml
    /// </summary>
    public partial class SubInventoryTabItem : MetroTabItem
    {
        public SaveFile SaveFile { get; }
        public SubInventoryTabItem(Inventory.SubInventory subInventory, SaveFile saveFile)
        {
            SaveFile = saveFile;
            InitializeComponent();
            Header = $"{subInventory.InventoryId:X}";
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
    }
}
