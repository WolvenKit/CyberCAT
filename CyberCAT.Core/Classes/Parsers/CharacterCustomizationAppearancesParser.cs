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
    class CharacterCustomizationAppearancesParser : INodeParser
    {
        public string ParsableNodeName { get; set; }

        public CharacterCustomizationAppearancesParser()
        {
            ParsableNodeName = Constants.NodeNames.CHARACTER_CUSTOMIZATION_APPEARANCES_NODE;
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            if (node.Name != ParsableNodeName)
            {
                throw new Exception("Unexpected SectionName");
            }
            var result = new CharacterCustomizationAppearances();

            reader.BaseStream.Position = node.Offset;
            reader.Skip(4); //Skip the ID
            reader.Skip(15); // unknown bytes at start

            ParseSection(reader, result);
            ParseSection(reader, result);
            ParseSection(reader, result);
            ParseSection(reader, result);

            var count = reader.ReadInt32(); // holstered and unholstered stuff

            for (int i = 0; i < count; ++i)
            {
                ParseSection(reader, result);
            }

            count = reader.ReadInt32();

            for (int i = 0; i < count; ++i)
            {
                ParseSection(reader, result);
            }

            var unknown = reader.ReadInt32(); // it is not the count of the following strings...

            count = 18;

            for (int i = 0; i < count; ++i)
            {
                var s = ParserUtils.ReadString(reader);
            }

            reader.Skip(1); // 0x02 in my saves, could be a count

            result.HelmetHairColor = ParserUtils.ReadString(reader);
            result.HelmetHairLength = ParserUtils.ReadString(reader);

            return result;
        }

        private void ParseSection(BinaryReader reader, CharacterCustomizationAppearances result)
        {
            var sectionName = ParserUtils.ReadString(reader);
            var count = reader.ReadInt32(); // number of Instances section entries

            for (int i = 0; i < count; ++i)
            {
                result.Instances.Add(ParseAppearanceInstance(reader, sectionName));
            }

            reader.Skip(4); // seems to be always 0
        }

        private CharacterCustomizationAppearances.AppearanceInstance ParseAppearanceInstance(BinaryReader reader, string group)
        {
            var ai = new CharacterCustomizationAppearances.AppearanceInstance();
            ai.Group = group;
            ai.Hash = reader.ReadUInt64();
            ai.FirstString = ParserUtils.ReadString(reader, out ai.FirstFlags);
            ai.SecondString = ParserUtils.ReadString(reader, out ai.SecondFlags);
            var unknown1 = reader.ReadInt32();
            var unknown2 = reader.ReadInt32();
            // Sometimes both are 1, sometimes only unknown1 is 1 und unknown2 is zero
            return ai;
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            throw new NotImplementedException();
        }
    }
}
