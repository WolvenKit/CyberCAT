using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public class AppearanceSectionEntry
    {
        public string Displayname { get; set; }
        public ulong Hash { get; set; }
        public bool HasHash { get; set; }
        public List<string> AdditionalValues { get; set; }

        public AppearanceSectionEntry()
        {
            AdditionalValues = new List<string>();
            HasHash = false;
        }

    }
}
