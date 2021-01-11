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

namespace CyberCAT.Wpf
{
    public partial class InventoryViewer : UserControl
    {
        public InventoryViewer(SaveFile saveFile)
        {
            InitializeComponent();

            var inventoryNode = saveFile.Nodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.INVENTORY);
            if (inventoryNode == null)
            {
                return;
            }

            var inventory = (Inventory) inventoryNode.Value;

            foreach (var subInventory in inventory.SubInventories)
            {
                CreateSubInventoryTabPage(subInventory);
            }
        }

        private void CreateSubInventoryTabPage(Inventory.SubInventory subInventory)
        {
            InventoryTabControl.Items.Add(new SubInventoryTabItem(subInventory));
        }
    }
}
