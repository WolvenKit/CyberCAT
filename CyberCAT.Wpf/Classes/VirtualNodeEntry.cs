using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes;

namespace CyberCAT.Wpf.Classes
{
    public class VirtualNodeEntry : NodeEntry
    {
        public override string ToString()
        {
            return $"[V] {Value}";
        }
    }
}
