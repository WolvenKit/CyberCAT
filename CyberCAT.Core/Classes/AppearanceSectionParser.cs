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
    public class AppearanceSectionParser : ISectionParser
    {
        private static byte[] MagicNumberTPP = new byte[] { 0x50, 0x50, 0x54, 0x83 };
        private static byte[] MagicNumberFPP = new byte[] { 0x50, 0x50, 0x46, 0x83 };
        int eyeCounter = 0;
        int mantisCounter = 0;
        bool _containerMode = true;
        public string Json { get; set; }
        private AppearanceSection _section;

        public AppearanceSectionParser()
        {
            _section = new AppearanceSection();
        }

        public bool IsTriggered(Stack<byte> readHistory)
        {
            bool result = false;
            if (readHistory.Count >= 4)
            {
                byte[] partToCheck = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    partToCheck[i] = readHistory.Pop();
                }
                result = (partToCheck.SequenceEqual(MagicNumberTPP));
                for (int i = 3; i >= 0; i--)
                {
                    readHistory.Push(partToCheck[i]);
                }

            }
            return result;
        }

        public bool Parse(Stream inputStream)
        {
            using (BinaryReader reader = new BinaryReader(inputStream, Encoding.ASCII,true))
            {
                
                reader.BaseStream.Seek(-8, SeekOrigin.Current);
                
                
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    var container = ReadContainer(reader);
                    if (container.Blocks.Count == 0 && mantisCounter < 1)
                    {
                        _containerMode = false;
                        bool readBlocks = true;
                        while (readBlocks)
                        {

                            var block = ReadBlock(reader);
                            if (block.Entries.Count == 0)
                            {
                                readBlocks = false;
                                _containerMode = true;
                            }
                            else
                            {
                                _section.Containers[_section.Containers.Count - 1].TrailingBlocks.Add(block);
                            }
                        }
                    }
                    else if (container.Blocks.Count == 0 && mantisCounter >= 1)
                    {
                        break;//Parsing seems to change
                    }
                    else
                    {
                        _section.Containers.Add(container);
                    }
                    
                }
            }
            Json = _section.GetJson();
            return true;//TODO validity check
        }
        private AppearanceBlockContainer ReadContainer(BinaryReader reader)
        {
            var result = new AppearanceBlockContainer();
            var containerSize = reader.ReadInt32();
            for(int i =0; i < containerSize; i++)
            {
                var block = ReadBlock(reader);
                result.Blocks.Add(block);
            }
            return result;
        }
        private AppearanceValueBlock ReadFirstBlock(BinaryReader reader)
        {
            
            var flags = ReadFlags(reader.ReadByte());
            string blockName = reader.ReadString(flags.Length);
            var block = new AppearanceValueBlock(blockName);
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                var entry = new AppearanceSectionEntry();
                if (flags.HasUnknownFlag)
                {
                    entry.Hash = reader.ReadUInt64();
                    entry.HasHash = true;
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        if (reader.PeekByte() != 0x0)
                        {
                            var testFlag = ReadFlags(reader.ReadByte());
                            string additionalValue = reader.ReadString(testFlag.Length);
                            entry.AdditionalValues.Add(additionalValue);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                block.Entries.Add(entry);
                reader.Skip(8);
            }
            return block;
        }
        private AppearanceValueBlock ReadBlock(BinaryReader reader)
        {
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                if (reader.PeekByte() != 0x0)
                {
                    break;
                }
                else
                {
                    if (!_containerMode)
                    {
                        return new AppearanceValueBlock();
                    }
                    else
                    {
                        reader.Skip(1);
                    }
                }
            }
            var flags = ReadFlags(reader.ReadByte());
            var block = new AppearanceValueBlock();
            if (!flags.HasUnknownFlag)
            {
                reader.BaseStream.Seek(-1, SeekOrigin.Current);
                if (eyeCounter >= 2)
                {
                    eyeCounter = 0;
                    return new AppearanceValueBlock();//we saw "eyes" two Times reset to Containermode
                }
            }
            else
            {
                block.BlockName = reader.ReadString(flags.Length);
                block.IsUnnamed = false;
            }
            
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                var entry = new AppearanceSectionEntry();
                if (flags.HasUnknownFlag)
                {
                    entry.Hash = reader.ReadUInt64();
                    entry.HasHash = true;
                }
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    if (reader.PeekByte() != 0x0)
                    {
                        var testFlag = ReadFlags(reader.ReadByte());
                        string additionalValue = reader.ReadString(testFlag.Length);
                        if (additionalValue == "eyes")
                        {
                            eyeCounter++;
                        }
                        if (additionalValue.Contains("mantis"))
                        {
                            mantisCounter++;
                        }
                        entry.AdditionalValues.Add(additionalValue);
                    }
                    else
                    {
                        break;
                    }
                }

                block.Entries.Add(entry);
                reader.Skip(8);
            }
            return block;
        }
        private Flags ReadFlags(byte inputByte)
        {
            var result = new Flags();
            var flagByte = inputByte;
            result.Length = (byte)(flagByte - 128);
            result.HasUnknownFlag = (flagByte & 0x80) != 0; // don't know purpose yet
            return result;
        }
    }
}
