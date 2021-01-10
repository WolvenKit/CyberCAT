using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public string ParsableNodeName { get; }
        public string DisplayName { get; }
        public Guid Guid { get; }

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
            node.Parser = this;
            var result = new CharacterCustomizationAppearances();
            reader.Skip(4); //skip Id
            result.DataExists = reader.ReadBoolean();
            result.Unknown1 = reader.ReadUInt32();

            if (!result.DataExists)
            {
                return result;
            }

            result.UnknownFirstBytes = reader.ReadBytes(6);

            ReadSection(reader, result.FirstSection, ExpectedFirstSectionNames);
            ReadSection(reader, result.SecondSection, ExpectedSecondSectionNames);
            ReadSection(reader, result.ThirdSection, ExpectedThirdSectionNames);

            var count = reader.ReadUInt32();
            for (var i = 0; i < count; ++i)
            {
                result.StringTriples.Add(ReadStringTriple(reader));
            }

            // Only when SaveVersion > 171
            var scount = ParserUtils.ReadPackedInt(reader);
            for (var i = 0; i < scount; ++i)
            {
                result.Strings.Add(ParserUtils.ReadString(reader));
            }

            result.Node = node;
            return result;
        }

        private void ReadSection(BinaryReader reader, CharacterCustomizationAppearances.Section section, List<string> expectedSectionNames)
        {
            var count = reader.ReadUInt32();

            for (uint i = 0; i < count; ++i)
            {
                section.AppearanceSections.Add(ReadAppearanceSection(reader, expectedSectionNames));
            }
        }

        private CharacterCustomizationAppearances.AppearanceSection ReadAppearanceSection(BinaryReader reader, List<string> expectedNames)
        {
            var sectionName = ParserUtils.ReadString(reader);
            Debug.Assert(expectedNames.Contains(sectionName));

            var appearanceSection = new CharacterCustomizationAppearances.AppearanceSection {SectionName = sectionName};


            int count = reader.ReadInt32();
            if (count > 0)
            {
                ReadHashValueSection(reader, appearanceSection.MainList, count);
            }

            count = reader.ReadInt32();
            if (count > 0)
            {
                ReadValueSection(reader, appearanceSection.AdditionalList, count);
            }

            return appearanceSection;
        }

        private void ReadHashValueSection(BinaryReader reader, ObservableCollection<CharacterCustomizationAppearances.HashValueEntry> collection, int count)
        {
            for(int i = 0; i < count; i++)
            {
                var entry = new CharacterCustomizationAppearances.HashValueEntry();
                // CSE is doing a version check here on ArchiveVersion < 195
                // Unt64 only read if ArchiveVersion >= 195, otherwise: https://github.com/PixelRick/CyberpunkSaveEditor/blob/7c47c6c7ce099c714e2ba43515380f99a2422c20/Source/cserialization/cnodes/CCharacterCustomization.hpp#L74
                entry.Hash = reader.ReadUInt64();
                entry.FirstString = ParserUtils.ReadString(reader);
                entry.SecondString = ParserUtils.ReadString(reader);
                entry.TrailingBytes = reader.ReadBytes(8);
                collection.Add(entry);
            }
        }

        private void ReadValueSection(BinaryReader reader, ObservableCollection<CharacterCustomizationAppearances.ValueEntry> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var entry = new CharacterCustomizationAppearances.ValueEntry();
                entry.FirstString = ParserUtils.ReadString(reader);
                entry.SecondString = ParserUtils.ReadString(reader);
                entry.TrailingBytes = reader.ReadBytes(8);
                collection.Add(entry);
            }
        }

        private CharacterCustomizationAppearances.StringTriple ReadStringTriple(BinaryReader reader)
        {
            var result = new CharacterCustomizationAppearances.StringTriple();
            result.FirstString = ParserUtils.ReadString(reader);
            result.SecondString = ParserUtils.ReadString(reader);
            result.ThirdString = ParserUtils.ReadString(reader);
            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (CharacterCustomizationAppearances)node.Value;

            writer.Write(data.DataExists);
            writer.Write(data.Unknown1);
            if (data.DataExists)
            {
                writer.Write(data.UnknownFirstBytes);

                WriteSection(writer, data.FirstSection);
                WriteSection(writer, data.SecondSection);
                WriteSection(writer, data.ThirdSection);

                writer.Write(data.StringTriples.Count);
                foreach (var st in data.StringTriples)
                {
                    WriteStringTriple(writer, st);
                }

                // Only when SaveVersion > 171
                ParserUtils.WritePackedInt(writer, data.Strings.Count);
                foreach (var s in data.Strings)
                {
                    ParserUtils.WriteString(writer, s);
                }
            }
        }

        private void WriteSection(BinaryWriter writer, CharacterCustomizationAppearances.Section section)
        {
            writer.Write(section.AppearanceSections.Count);
            foreach (var appearanceSection in section.AppearanceSections)
            {
                WriteAppearanceSection(writer, appearanceSection);
            }
        }

        private void WriteAppearanceSection(BinaryWriter writer, CharacterCustomizationAppearances.AppearanceSection appearanceSection)
        {
            ParserUtils.WriteString(writer, appearanceSection.SectionName);

            writer.Write(appearanceSection.MainList.Count);
            foreach (var entry in appearanceSection.MainList)
            {
                writer.Write(entry.Hash);
                ParserUtils.WriteString(writer, entry.FirstString);
                ParserUtils.WriteString(writer, entry.SecondString);
                writer.Write(entry.TrailingBytes);
            }

            writer.Write(appearanceSection.AdditionalList.Count);
            foreach (var entry in appearanceSection.AdditionalList)
            {
                ParserUtils.WriteString(writer, entry.FirstString);
                ParserUtils.WriteString(writer, entry.SecondString);
                writer.Write(entry.TrailingBytes);
            }
        }

        private void WriteStringTriple(BinaryWriter writer, CharacterCustomizationAppearances.StringTriple st)
        {
            ParserUtils.WriteString(writer, st.FirstString);
            ParserUtils.WriteString(writer, st.SecondString);
            ParserUtils.WriteString(writer, st.ThirdString);
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
