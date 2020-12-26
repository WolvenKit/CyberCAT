using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class CharacterCustomizationAppearances
    {
        public class HashValueEntry
        {
            public ulong Hash { get; set; }
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public byte[] TrailingBytes { get; set; }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }

        public class ValueEntry
        {
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public byte[] TrailingBytes { get; set; }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }

        public class AppearanceSection
        {
            public string SectionName { get; set; }
            public List<HashValueEntry> MainList { get; set; }
            public List<ValueEntry> AdditionalList { get; set; }

            public AppearanceSection()
            {
                MainList = new List<HashValueEntry>();
                AdditionalList = new List<ValueEntry>();
            }

            public override string ToString()
            {
                return $"{SectionName} ({MainList.Count} / {AdditionalList.Count})";
            }
        }

        public class Section
        {
            public List<AppearanceSection> AppearanceSections { get; set; }

            public Section()
            {
                AppearanceSections = new List<AppearanceSection>();
            }

            public override string ToString()
            {
                return $"{AppearanceSections.Count} inner sections";
            }
        }

        public byte[] UnknownFirstBytes { get; set; }

        public Section FirstSection { get; set; }
        public Section SecondSection { get; set; }
        public Section ThirdSection { get; set; }

        /// <summary>
        /// Bytes that are not yet parsed into representation
        /// </summary>
        public byte[] TrailingBytes { get; set; }

        public CharacterCustomizationAppearances()
        {
            FirstSection = new Section();
            SecondSection = new Section();
        }
       
    }
}
