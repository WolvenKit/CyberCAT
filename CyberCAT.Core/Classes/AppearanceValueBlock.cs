using CyberCAT.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public class AppearanceValueBlock
    {
        public string BlockName { get; set; }
        public bool IsUnnamed { get; set; }
        public List<AppearanceSectionEntry> Entries;
        public AppearanceValueBlock(string name)
        {
            BlockName = name;
            Entries = new List<AppearanceSectionEntry>();
        }
        public AppearanceValueBlock()
        {
            Entries = new List<AppearanceSectionEntry>();
            IsUnnamed = true;
        }
    }
}
