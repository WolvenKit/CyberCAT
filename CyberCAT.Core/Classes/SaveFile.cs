using CyberCAT.Core.ChunkedLz4;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.Parsers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.NodeRepresentations;
using Newtonsoft.Json;

namespace CyberCAT.Core.Classes
{
    public class SaveFile
    {
        public int Version1;
        public int Version2;
        public int Version3;
        public byte[] SkippedHeaderBytes;
        public List<NodeEntry> Nodes;
        public int LastBlockOffset;
        public List<NodeEntry> FlatNodes = new List<NodeEntry>();//flat structure
        List<INodeParser> _parsers;
        /// <summary>
        /// Creates a new Instance of Save File wich will utilize given parsers
        /// </summary>
        /// <param name="parsers">The parsers that will be used for parsing</param>
        public SaveFile(IEnumerable<INodeParser> parsers)
        {
            _parsers = new List<INodeParser>();
            _parsers.AddRange(parsers);
        }
        public SaveFile()
        {
            Nodes = new List<NodeEntry>();
            //TODO do this with dependency injection or Reflection and a Plugin type DLL Folder
            _parsers = new List<INodeParser>();
            _parsers.Add(new GameSessionConfigParser());
            _parsers.Add(new CharacterCustomizationAppearancesParser());
            _parsers.Add(new ItemDataParser());
            _parsers.Add(new InventoryParser());
            _parsers.Add(new FactsTableParser());
            _parsers.Add(new ItemDropStorageParser());
            _parsers.Add(new ItemDropStorageManagerParser());
        }
        public void LoadFromCompressedStream(Stream inputStream)
        {
            FlatNodes = new List<NodeEntry>();
            Nodes = new List<NodeEntry>();
            using (var reader = new BinaryReader(inputStream, Encoding.ASCII, true))
            {
                string magic = reader.ReadString(4);
                Version1 = reader.ReadInt32();
                Version2 = reader.ReadInt32();
                SkippedHeaderBytes = reader.ReadBytes(9);
                Version3 = reader.ReadInt32();
                int blockInfoStart = (int)reader.BaseStream.Position;
                reader.BaseStream.Seek(-8, SeekOrigin.End);
                LastBlockOffset = reader.ReadInt32();
                reader.BaseStream.Seek(LastBlockOffset, SeekOrigin.Begin);
                string edonMagic = reader.ReadString(4);
                var flags = new Flags(reader);
                for (int i = 0; i < flags.Length; i++)
                {
                    var tmpFlags = new Flags(reader.ReadByte());
                    string name = reader.ReadString(tmpFlags.Length);
                    var entry = new NodeEntry();
                    entry.NextId = reader.ReadInt32();
                    entry.ChildId = reader.ReadInt32();
                    entry.Offset = reader.ReadInt32();
                    entry.Size = reader.ReadInt32();
                    entry.Name = name;
                    FlatNodes.Add(entry);
                }
            }
            inputStream.Seek(0, SeekOrigin.Begin);
            var activeSaveFile = new SaveFileCompressionHelper();
            var decompressedFile = activeSaveFile.Decompress(inputStream);
            using (MemoryStream memoryStream = new MemoryStream(decompressedFile))
            {
                using (BinaryReader reader = new BinaryReader(memoryStream, Encoding.ASCII))
                {
                    foreach (var node in FlatNodes)
                    {
                        reader.BaseStream.Position = node.Offset;
                        node.Id = reader.ReadInt32();
                    }
                    foreach (var node in FlatNodes)
                    {
                        if (!node.IsChild)
                        {
                            FindChildren(FlatNodes, node, FlatNodes.Count);
                        }
                        if (node.NextId > -1)
                        {
                            node.SetNextNode(FlatNodes.Where(n => n.Id == node.NextId).FirstOrDefault());
                        }
                    }
                    Nodes.AddRange(FlatNodes.Where(n => !n.IsChild));
                    CalculateTrueSizes();
                    ParserUtils.ParseChildren(Nodes, reader, _parsers);
                }
            }
        }
        public byte[] Save()
        {
            byte[] uncompressedData;

            using(var stream = new MemoryStream())
            {
                foreach(var node in Nodes)
                {
                    var parser = _parsers.Where(p => p.ParsableNodeName == node.Name).FirstOrDefault();
                    if (parser != null)
                    {
                        stream.Write(parser.Write(node, _parsers));
                    }
                    else
                    {
                        var fallback = new DefaultParser();
                        stream.Write(fallback.Write(node, _parsers));
                    }
                }
                uncompressedData = stream.ToArray();
            }

            RecalculateOffsets();
            var footerWithoutLast8Bytes= BuildFooterWithoutLastEightBytes();
            var compressor = new SaveFileCompressionHelper();
            var chunks = compressor.CompressToChunkList(uncompressedData);
            var header = BuildHeader(chunks);
            byte[] result;
            using(var stream = new MemoryStream())
            {
                using(var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(header);
                    foreach(var chunk in chunks)
                    {
                        writer.Write(chunk.CompressedData);
                    }
                    int lastBlockOffset = (int)writer.BaseStream.Position;
                    writer.Write(footerWithoutLast8Bytes);
                    writer.Write(lastBlockOffset);
                    writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.END_OF_FILE));
                }
                result = stream.ToArray();
            }
            return result;
        }
        byte[] BuildHeader(List<Lz4Chunk> chunks)
        {
            byte[] result;
            using(var stream = new MemoryStream())
            {
                using(var writer = new BinaryWriter(stream,Encoding.ASCII))
                {
                    writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.FIRST_FILE_HEADER_MAGIC));
                    writer.Write(Version1);
                    writer.Write(Version2);
                    writer.Write(SkippedHeaderBytes);
                    writer.Write(Version3);
                    writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.SECOND_FILE_HEADER_MAGIC));
                    writer.Write(chunks.Count);
                    writer.Write(Constants.Numbers.DEFAULT_HEADER_SIZE);
                    int offset = Constants.Numbers.DEFAULT_HEADER_SIZE;
                    int index = 0;
                    foreach (var chunk in chunks)
                    {
                        writer.Write(chunk.CompressedData.Length);//CompressedChunkSize
                        writer.Write(chunk.DecompressedChunkSize);//DecompressedChunkSize
                        offset = offset + chunk.CompressedChunkSize;
                        if (index < chunks.Count - 1)
                        {
                            writer.Write(offset);//EndOfChunkOffset
                        }
                        index++;
                    }
                    while (writer.BaseStream.Position < Constants.Numbers.DEFAULT_HEADER_SIZE)
                    {
                        writer.Write((byte)0);
                    }
                }
                result = stream.ToArray();
            }
            
            return result;
        }
        byte[] BuildFooterWithoutLastEightBytes()
        {
            byte[] result;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.NODE_INFORMATION_START));
                    writer.WriteBit6(FlatNodes.Count);
                    foreach (var node in FlatNodes)
                    {
                        writer.Write((byte)(node.Name.Length + 128));
                        writer.Write(Encoding.ASCII.GetBytes(node.Name));
                        writer.Write(node.NextId);
                        writer.Write(node.ChildId);
                        writer.Write(node.Offset);
                        writer.Write(node.Size);
                    }
                }
                result = stream.ToArray();
            }
            return result;
        }
        void CalculateTrueSizes()
        {
            
            for(int i =0; i < FlatNodes.Count-1; i++)
            {
                var node = FlatNodes[i];
                var next = FlatNodes[i + 1];
                node.TrueSize = next.Offset - node.Offset;
            }
            FlatNodes[FlatNodes.Count - 1].TrueSize = FlatNodes[FlatNodes.Count - 1].Size;//I believe
        }
        void RecalculateOffsets()
        {
            FlatNodes[0].Offset= Constants.Numbers.DEFAULT_HEADER_SIZE;
            for (int i =1; i < FlatNodes.Count;i++)
            {
                var previousNode = FlatNodes[i - 1];
                FlatNodes[i].Offset = previousNode.Offset + previousNode.TrueSize;
            }
        }
        private void FindChildren(List<NodeEntry> nodes, NodeEntry node, int maxNextId)
        {
            if (node.ChildId > -1)
            {
                var nextId = node.NextId;
                if (nextId == -1)
                {
                    nextId = maxNextId;
                }
                for (int i = node.ChildId; i < nextId; i++)
                {
                    var possibleChild = nodes.Where(n => n.Id == i).FirstOrDefault();
                    if (possibleChild == null)
                    {
                        Debugger.Break();
                    }
                    if (possibleChild.ChildId > -1)//SubChild
                    {
                        FindChildren(nodes, possibleChild, nextId);
                        node.AddChild(possibleChild);
                    }
                    else
                    {
                        if (!possibleChild.IsChild)//was already added
                        {
                            node.AddChild(possibleChild);
                        }
                        
                    }

                }
            }
        }
    }
}
