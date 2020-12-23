using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class CharacterCustomizationAppearances
    {
        public struct AppearanceInstance
        {
            public string Group;
            public ulong Hash;
            public Flags FirstFlags;
            public string FirstString;
            public Flags SecondFlags;
            public string SecondString;
        }

        public List<AppearanceInstance> Instances = new List<AppearanceInstance>();

        public string HelmetHairColor;
        public string HelmetHairLength;
    }
}
