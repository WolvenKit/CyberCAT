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
            reader.Skip(4);//skip Id
            result.UnknownFirstBytes=reader.ReadBytes(15);
            var tppTest = ParserUtils.ReadString(reader);
            Debug.Assert(tppTest == Constants.Parsing.TPP_SECTION_NAME);
            int count = reader.ReadInt32();
            result.ThirdPerson.AddRange(ReadHashValueSection(reader, count));
            int readSize = node.TrueSize - ((int)reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes(readSize);
            return result;
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
                entry.TrailingBytes=reader.ReadBytes(8);
                result.Add(entry);
            }
            return result;
        }
        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (CharacterCustomizationAppearances)node.Value;
            using(var stream = new MemoryStream())
            {
                using(var writer = new BinaryWriter(stream,Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(data.UnknownFirstBytes);
                    writer.Write((byte)(Constants.Parsing.TPP_SECTION_NAME.Length+128));
                    writer.Write(Encoding.ASCII.GetBytes(Constants.Parsing.TPP_SECTION_NAME));
                    writer.Write(data.ThirdPerson.Count);
                    foreach(var entry in data.ThirdPerson)
                    {
                        writer.Write(entry.Hash);
                        writer.Write((byte)(entry.FirstString.Length+128));
                        writer.Write(Encoding.ASCII.GetBytes(entry.FirstString));
                        writer.Write((byte)(entry.SecondString.Length + 128));
                        writer.Write(Encoding.ASCII.GetBytes(entry.SecondString));
                        writer.Write(entry.TrailingBytes);
                    }
                    writer.Write(data.TrailingBytes);
                }
                result = stream.ToArray();
            }
            node.TrueSize = result.Length;
            return result;
        }
    }
}
