using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class Inventory
    {
        public class SubInventory
        {
            public ulong InventoryId { get; set; }
            public uint NumberOfItems { get; set; }
            public ItemData.NextItemEntry[] ItemHeaders { get; set; }
            public ItemData[] Items { get; set; }

            public override string ToString()
            {
                return $"{InventoryId:X}";
            }
        }
        public uint NumberOfInventories { get; set; }

        public SubInventory[] SubInventories { get; set; }
    }
}
