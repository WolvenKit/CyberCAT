using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class CharacterCustomizationAppearancesParser : INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set;}

        public CharacterCustomizationAppearancesParser()
        {
            ParsableNodeName = Constants.NodeNames.CHARACTER_CUSTOMIZATION_APPEARANCES_NODE;
            DisplayName = "Character Appearance Parser";
            Guid = Guid.Parse("{0AFC700B-23C0-4C4A-AFCB-5D39443BD68F}");
        }

        private static List<string> ExpectedFirstSectionNames = new List<string>
        {
            Constants.Parsing.TPP_SECTION_NAME,
            Constants.Parsing.FPP_SECTION_NAME,
            Constants.Parsing.HAIRS_SECTION_NAME,
            Constants.Parsing.CHARACTER_CUSTOMIZATION_SECTION_NAME
        };

        private static List<string> ExpectedSecondSectionNames = new List<string>
        {
            Constants.Parsing.HOLSTERED_DEFAULT_SECTION_NAME,
            Constants.Parsing.HOLSTERED_STRONG_SECTION_NAME,
            Constants.Parsing.HOLSTERED_NANOWIRE_SECTION_NAME,
            Constants.Parsing.HOLSTERED_LAUNCHER_SECTION_NAME,
            Constants.Parsing.HOLSTERED_MANTIS_SECTION_NAME,
            Constants.Parsing.HOLSTERED_DEFAULT_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_DEFAULT_FPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_STRONG_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_STRONG_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_STRONG_SECTION_NAME,
            Constants.Parsing.HOLSTERED_NANOWIRE_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_NANOWIRE_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_NANOWIRE_SECTION_NAME,
            Constants.Parsing.CHARACTER_CUSTOMIZATION_SECTION_NAME, // Yes, in both sections
            Constants.Parsing.PERSONAL_LINK_SIMPLE_SECTION_NAME,
            Constants.Parsing.PERSONAL_LINK_ADVANCED_SECTION_NAME,
            Constants.Parsing.HOLSTERED_LAUNCHER_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_LAUNCHER_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_LAUNCHER_SECTION_NAME,
            Constants.Parsing.HOLSTERED_MANTIS_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_MANTIS_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_MANTIS_SECTION_NAME,
        };

        private static List<string> ExpectedThirdSectionNames = new List<string>
        {
            Constants.Parsing.FPP_BODY_SECTION_NAME,
            Constants.Parsing.TPP_BODY_SECTION_NAME,
            Constants.Parsing.CHARACTER_CREATION_SECTION_NAME,
            Constants.Parsing.GENITALS_SECTION_NAME,
            Constants.Parsing.BREAST_SECTION_NAME,
            Constants.Parsing.LIFTED_FEET_SECTION_NAME,
            Constants.Parsing.FLAT_FEET_SECTION_NAME
        };

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            if (node.Name != ParsableNodeName)
            {
                throw new Exception("Unexpected SectionName");
            }
            var result = new CharacterCustomizationAppearances();
            reader.Skip(4); //skip Id
            result.UnknownFirstBytes = reader.ReadBytes(11);

            result.FirstSection = ReadSection(reader, ExpectedFirstSectionNames);

            result.SecondSection = ReadSection(reader, ExpectedSecondSectionNames);

            result.ThirdSection = ReadSection(reader, ExpectedThirdSectionNames);

            int readSize = node.DataSize - ((int)reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes(readSize);
            return result;
        }

        private CharacterCustomizationAppearances.Section ReadSection(BinaryReader reader, List<string> expectedSectionNames)
        {
            var count = reader.ReadUInt32();

            var section = new CharacterCustomizationAppearances.Section();
            for (uint i = 0; i < count; ++i)
            {
                section.AppearanceSections.Add(ReadAppearanceSection(reader, expectedSectionNames));
            }

            return section;
        }

        private CharacterCustomizationAppearances.AppearanceSection ReadAppearanceSection(BinaryReader reader, List<string> expectedNames)
        {
            var sectionName = ParserUtils.ReadString(reader);
            Debug.Assert(expectedNames.Contains(sectionName));

            var appearanceSection = new CharacterCustomizationAppearances.AppearanceSection {SectionName = sectionName};


            int count = reader.ReadInt32();
            appearanceSection.MainList.AddRange(ReadHashValueSection(reader, count));

            count = reader.ReadInt32();
            if (count > 0)
            {
                appearanceSection.AdditionalList.AddRange(ReadValueSection(reader, count));
            }

            return appearanceSection;
        }

        private List<CharacterCustomizationAppearances.HashValueEntry> ReadHashValueSection(BinaryReader reader, int count)
        {
            var result = new List<CharacterCustomizationAppearances.HashValueEntry>();
            for(int i = 0; i < count; i++)
            {
                var entry = new CharacterCustomizationAppearances.HashValueEntry();
                entry.Hash = reader.ReadUInt64();
                entry.FirstString = ParserUtils.ReadString(reader);
                entry.SecondString = ParserUtils.ReadString(reader);
                entry.TrailingBytes = reader.ReadBytes(8);
                result.Add(entry);
            }
            return result;
        }

        private List<CharacterCustomizationAppearances.ValueEntry> ReadValueSection(BinaryReader reader, int count)
        {
            var result = new List<CharacterCustomizationAppearances.ValueEntry>();
            for (int i = 0; i < count; i++)
            {
                var entry = new CharacterCustomizationAppearances.ValueEntry();
                entry.FirstString = ParserUtils.ReadString(reader);
                entry.SecondString = ParserUtils.ReadString(reader);
                entry.TrailingBytes = reader.ReadBytes(8);
                result.Add(entry);
            }
            return result;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers, int parentHeaderSize)
        {
            byte[] result;
            var data = (CharacterCustomizationAppearances)node.Value;
            using(var stream = new MemoryStream())
            {
                using(var writer = new BinaryWriter(stream,Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(data.UnknownFirstBytes);

                    WriteSection(writer, data.FirstSection);
                    WriteSection(writer, data.SecondSection);
                    WriteSection(writer, data.ThirdSection);

                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }

            ParserUtils.AdjustNodeOffsetDuringWriting(node, result.Length, parentHeaderSize);

            return result;
        }

        public void WriteSection(BinaryWriter writer, CharacterCustomizationAppearances.Section section)
        {
            writer.Write(section.AppearanceSections.Count);
            foreach (var appearanceSection in section.AppearanceSections)
            {
                WriteAppearanceSection(writer, appearanceSection);
            }
        }

        public void WriteAppearanceSection(BinaryWriter writer, CharacterCustomizationAppearances.AppearanceSection appearanceSection)
        {
            writer.Write((byte)(appearanceSection.SectionName.Length + 128));
            writer.Write(Encoding.ASCII.GetBytes(appearanceSection.SectionName));

            writer.Write(appearanceSection.MainList.Count);
            foreach (var entry in appearanceSection.MainList)
            {
                writer.Write(entry.Hash);
                writer.Write((byte)(entry.FirstString.Length + 128));
                writer.Write(Encoding.ASCII.GetBytes(entry.FirstString));
                writer.Write((byte)(entry.SecondString.Length + 128));
                writer.Write(Encoding.ASCII.GetBytes(entry.SecondString));
                writer.Write(entry.TrailingBytes);
            }

            writer.Write(appearanceSection.AdditionalList.Count);
            foreach (var entry in appearanceSection.AdditionalList)
            {
                writer.Write((byte)(entry.FirstString.Length + 128));
                writer.Write(Encoding.ASCII.GetBytes(entry.FirstString));
                writer.Write((byte)(entry.SecondString.Length + 128));
                writer.Write(Encoding.ASCII.GetBytes(entry.SecondString));
                writer.Write(entry.TrailingBytes);
            }
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
