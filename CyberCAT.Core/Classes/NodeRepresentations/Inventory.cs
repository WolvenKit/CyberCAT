using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Annotations;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class Inventory : NodeRepresentation
    {
        private ObservableCollection<SubInventory> _subInventories;

        [JsonObject]
        public class SubInventory : INotifyPropertyChanged
        {
            private ulong _inventoryId;
            //private ObservableCollection<ItemData.NextItemEntry> _itemHeaders;
            private ObservableCollection<ItemData> _items;

            public ulong InventoryId
            {
                get => _inventoryId;
                set
                {
                    _inventoryId = value;
                    OnPropertyChanged();
                }
            }

            public uint NumberOfItems => (uint)Items.Count;

            //public ObservableCollection<ItemData.NextItemEntry> ItemHeaders => _itemHeaders;

            public ObservableCollection<ItemData> Items => _items;

            public override string ToString()
            {
                return $"[{InventoryId:X}] {NumberOfItems} items";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public SubInventory()
            {
                _items = new NotifyingObservableCollection<ItemData>();
                _items.CollectionChanged += (sender, args) =>
                {
                    OnPropertyChanged(nameof(Items));
                    OnPropertyChanged(nameof(NumberOfItems));
                };
            }
        }

        public uint NumberOfInventories => (uint)SubInventories.Count;

        public ObservableCollection<SubInventory> SubInventories => _subInventories;

        public Inventory()
        {
            _subInventories = new NotifyingObservableCollection<SubInventory>();
            _subInventories.CollectionChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(SubInventories));
            };
        }

        /// <summary>
        /// This method will add the specified item to the first inventory (the player inventory)
        /// </summary>
        /// <param name="item">The item that should be added</param>
        public void AddItem(ItemData item)
        {
            SubInventories[0].Items.Add(item);
            var node = new NodeEntry {Name = "itemData", Value = item};
            Node.Children.Add(node);
            item.Node = node;
        }
    }
}
