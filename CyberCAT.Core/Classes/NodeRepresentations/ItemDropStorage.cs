using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ItemDropStorage
    {
        public string UnknownString { get; set; }
        public byte[] HeaderBytes { get; set; }
        public Inventory.SubInventory Inventory { get; set; }
    }
}
