using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Forms.Classes
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class InventoryDisplay : Inventory
    {
        public InventoryDisplay(Inventory source)
        {
            HeaderBytes = source.HeaderBytes;
            NumberOfItems = source.NumberOfItems;
            TrailingBytes = source.TrailingBytes;
        }
    }
}
