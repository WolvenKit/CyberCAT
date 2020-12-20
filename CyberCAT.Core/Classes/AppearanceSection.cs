using CyberCAT.Core.Enums;
using CyberCAT.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    class AppearanceSection : ISaveFileSection
    {
        public List<AppearanceBlockContainer> Containers;
        public AppearanceSection()
        {
            Type = SaveFileSectionType.Appearance;
            Containers = new List<AppearanceBlockContainer>();
        }
        public SaveFileSectionType Type { get; set; }

        public byte[] WriteToBuffer(byte[] buffer, int position)
        {
            throw new NotImplementedException();
        }
        public string GetJson()
        {
            return JsonConvert.SerializeObject(Containers, Formatting.Indented);
        }
    }
}
