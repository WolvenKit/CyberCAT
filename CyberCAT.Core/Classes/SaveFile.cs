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
        public List<NodeEntry> FlatNodes; //flat structure
        public Guid Guid { get; private set;}
        List<INodeParser> _parsers;
        /// <summary>
        /// Creates a new Instance of Save File wich will utilize given parsers
        /// </summary>
        /// <param name="parsers">The parsers that will be used for parsing</param>
        public SaveFile(IEnumerable<INodeParser> parsers)
        {
            _parsers = new List<INodeParser>();
            _parsers.AddRange(parsers);
            Guid = Guid.NewGuid();
            FlatNodes = new List<NodeEntry>();
            Nodes = new List<NodeEntry>();
        }
        public SaveFile()
        {
            FlatNodes = new List<NodeEntry>();
            Nodes = new List<NodeEntry>();
            _parsers = new List<INodeParser>();
            var interfaceType = typeof(INodeParser);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass && p != typeof(DefaultParser));
            foreach (var type in types)
            {
                INodeParser instance = (INodeParser)Activator.CreateInstance(type);
                _parsers.Add(instance);
            }
        }
        public void LoadPCSaveFile(Stream inputStream)
        {
            BeginLoading(inputStream);
            var activeSaveFile = new SaveFileCompressionHelper();
            var decompressedFile = activeSaveFile.Decompress(inputStream);
            LoadFromByteArray(decompressedFile, decompressedFile.Length - activeSaveFile.MetaInformation.RestOfContent.Length);
        }

        public void LoadPS4SaveFile(Stream inputStream)
        {
            BeginLoading(inputStream);
            LoadFromStream(inputStream, LastBlockOffset);
        }

        private void BeginLoading(Stream inputStream)
        {
            FlatNodes.Clear();
            Nodes.Clear();
            using (var reader = new BinaryReader(inputStream, Encoding.ASCII, true))
            {
                // TODO: https://discord.com/channels/717692382849663036/789565732726767636/795711671850369105
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
        }

        private void LoadFromByteArray(byte[] data, int dataEnd)
        {
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                LoadFromStream(memoryStream, dataEnd);
            }
        }

        private void LoadFromStream(Stream stream, int dataEnd)
        {
            using (BinaryReader reader = new BinaryReader(stream, Encoding.ASCII))
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
                CalculateTrueSizes(Nodes, dataEnd);
                ParserUtils.ParseChildren(Nodes, reader, _parsers);
            }
        }

        public byte[] SaveToPCSaveFile()
        {
            var uncompressedData = GetNodeData();

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

        public byte[] SaveToPS4SaveFile()
        {
            var uncompressedData = GetNodeData();

            var footerWithoutLast8Bytes = BuildFooterWithoutLastEightBytes();
            var compressor = new SaveFileCompressionHelper();
            var chunks = compressor.CompressToChunkList(uncompressedData);
            foreach (var chunk in chunks)
            {
                chunk.CompressedChunkSize = 4 << 16;
                chunk.DecompressedChunkSize = 4 << 16;
                chunk.CompressedData = new byte[4 << 16];
                chunk.DecompressedData = new byte[0];
            }

            var offset = (chunks.Count - 1) * 4;

            chunks.Last().DecompressedChunkSize = uncompressedData.Length - (offset << 16);
            chunks.Last().CompressedData = new byte[uncompressedData.Length - (offset << 16)];
            var header = BuildHeader(chunks);
            //var header = BuildHeader(new List<Lz4Chunk>());
            byte[] result;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(header);
                    writer.Write(uncompressedData);
                    int lastBlockOffset = (int)writer.BaseStream.Position;
                    writer.Write(footerWithoutLast8Bytes);
                    writer.Write(lastBlockOffset);
                    writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.END_OF_FILE));
                }
                result = stream.ToArray();
            }
            return result;
        }

        public byte[] GetNodeData()
        {
            byte[] uncompressedData;

            using (var stream = new MemoryStream())
            {
                foreach (var node in Nodes)
                {
                    var parser = _parsers.Where(p => p.ParsableNodeName == node.Name).FirstOrDefault();
                    if (parser != null)
                    {
                        stream.Write(parser.Write(node, _parsers, 0));
                    }
                    else
                    {
                        var fallback = new DefaultParser();
                        stream.Write(fallback.Write(node, _parsers, 0));
                    }
                }
                uncompressedData = stream.ToArray();
            }

            return uncompressedData;
        }

        private byte[] BuildHeader(List<Lz4Chunk> chunks)
        {
            byte[] result;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
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
                        writer.Write(chunk.CompressedData.Length); //CompressedChunkSize
                        writer.Write(chunk.DecompressedChunkSize); //DecompressedChunkSize
                        offset = offset + chunk.CompressedChunkSize;
                        if (index < chunks.Count - 1)
                        {
                            writer.Write(offset); //EndOfChunkOffset
                        }

                        index++;
                    }

                    while (writer.BaseStream.Position < Constants.Numbers.DEFAULT_HEADER_SIZE)
                    {
                        writer.Write((byte) 0);
                    }
                }

                result = stream.ToArray();
            }

            return result;
        }

        private byte[] BuildFooterWithoutLastEightBytes()
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

        private void CalculateTrueSizes(IReadOnlyList<NodeEntry> nodes, int maxLength)
        {
            for (var i = 0; i < nodes.Count; ++i)
            {
                var currentNode = nodes[i];
                var prevNode = i > 0 ? nodes[i] : null;
                var nextNode = i + 1 < nodes.Count ? nodes[i + 1] : null;

                if (currentNode.Children.Count > 0)
                {
                    // Check if there is a blob before the first child
                    var nextChild = currentNode.Children.First();
                    var blobSize = nextChild.Offset - currentNode.Offset;
                    currentNode.DataSize = blobSize;
                    CalculateTrueSizes(currentNode.Children, maxLength);
                }
                else
                {
                    currentNode.DataSize = currentNode.Size;
                }

                if (nextNode != null)
                {
                    // There is a node after us. Check if there is a blob in between
                    var blobSize = nextNode.Offset - (currentNode.Offset + currentNode.Size);
                    currentNode.TrailingSize = blobSize;
                }
                else
                {
                    // There might be a blob that is part of the children due to the parents size, check for that
                    if (currentNode.GetParent() == null)
                    {
                        // This is the last node on the root list. Trailing data should have been cought by the last inner child and assigned here but check again.
                        var lastNodeEnd = currentNode.Offset + currentNode.Size;
                        Debug.Assert(lastNodeEnd <= maxLength);
                        if (lastNodeEnd < maxLength)
                        {
                            // There is a trailing blob
                            currentNode.TrailingSize = maxLength - lastNodeEnd;
                        }

                        continue;
                    }
                    nextNode = currentNode.GetParent().GetNextNode();
                    if (nextNode == null)
                    {
                        // This is the last child on the last node. The next valid offset would be the end of the data
                        // Create a virtual node for this so the code below can grab the offset
                        nextNode = new NodeEntry();
                        nextNode.Offset = maxLength;
                    }
                    var parentMax = currentNode.GetParent().Offset + currentNode.GetParent().Size;
                    var childMax = currentNode.Offset + currentNode.Size;
                    // The parent size should never be smaller than the end of the last child.
                    Debug.Assert(parentMax >= childMax);
                    var blobSize = nextNode.Offset - (currentNode.Offset + currentNode.Size);
                    if (parentMax > childMax)
                    {
                        // Blob belongs to this child
                        currentNode.TrailingSize = blobSize;
                    }
                    else if (parentMax == childMax)
                    {
                        // Blob belongs to the parent but as trailing.
                        currentNode.GetParent().TrailingSize = blobSize;
                    }
                }
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
