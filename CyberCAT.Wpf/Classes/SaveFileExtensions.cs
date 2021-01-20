using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CyberCAT.Core;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Wpf.Classes
{
    public static class SaveFileExtensions
    {
        public static Inventory GetInventory(this SaveFile saveFile)
        {
            return ((Inventory) saveFile.Nodes.FirstOrDefault(_ => _.Name == Constants.NodeNames.INVENTORY)?.Value);
        }
    }
}
