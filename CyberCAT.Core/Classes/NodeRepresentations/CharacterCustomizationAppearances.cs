using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class CharacterCustomizationAppearances
    {
        [JsonObject]
        public class StringTriple
        {
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public string ThirdString { get; set; }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString} / {ThirdString}";
            }
        }

        [JsonObject]
        public class HashValueEntry
        {
            public ulong Hash { get; set; }
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public byte[] TrailingBytes { get; set; }

            public HashValueEntry()
            {
                TrailingBytes = new byte[8];
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }

        [JsonObject]
        public class ValueEntry
        {
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public byte[] TrailingBytes { get; set; }

            public ValueEntry()
            {
                TrailingBytes = new byte[8];
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }

        [JsonObject]
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

        [JsonObject]
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

        public bool DataExists { get; set; }
        public uint Unknown1 { get; set; }
        public byte[] UnknownFirstBytes { get; set; }

        public Section FirstSection { get; set; }
        public Section SecondSection { get; set; }
        public Section ThirdSection { get; set; }

        public List<StringTriple> StringTriples { get; set; }
        public List<string> Strings { get; set; }

        public CharacterCustomizationAppearances()
        {
            FirstSection = new Section();
            SecondSection = new Section();
            StringTriples = new List<StringTriple>();
            Strings = new List<string>();
        }
       
    }
}
