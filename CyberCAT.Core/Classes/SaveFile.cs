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
using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;
using Newtonsoft.Json;

namespace CyberCAT.Core.Classes
{
    public class SaveFile
    {
        public class SaveFileHeader
        {
            public byte[] Magic { get; set; }
            public uint SaveVersion { get; set; }
            public uint GameVersion { get; set; }
            public byte Padding { get; set; }
            public uint Clock { get; set; }
            public uint Date { get; set; }
            public uint ArchiveVersion { get; set; }

            public byte Hour => (byte) (Clock >> 22);
            public byte Minutes => (byte) ((Clock >> 16) & 63);
            public byte Seconds => (byte) ((Clock >> 10) & 63);
            public byte Millis => (byte) (Clock & 1023);

            public short Year => (short) (Date >> 20);
            public byte Month => (byte) (1 + (Date >> 15) % (1 << 5));
            public byte Day => (byte)(1 + (Date >> 10) % (1 << 5));

            public void ReadSaveFileHeader(BinaryReader reader)
            {
                Magic = reader.ReadBytes(4);
                SaveVersion = reader.ReadUInt32();
                GameVersion = reader.ReadUInt32();
                Padding = reader.ReadByte();
                Clock = reader.ReadUInt32();
                Date = reader.ReadUInt32();
                ArchiveVersion = reader.ReadUInt32();
            }

            public void Write(BinaryWriter writer)
            {
                writer.Write(Magic);
                writer.Write(SaveVersion);
                writer.Write(GameVersion);
                writer.Write(Padding);
                writer.Write(Clock);
                writer.Write(Date);
                writer.Write(ArchiveVersion);
            }

            public override string ToString()
            {
                return $"v{SaveVersion}_{GameVersion}_{ArchiveVersion} saved at {Year}-{Month}-{Day} {Hour}:{Minutes}:{Seconds}.{Millis}";
            }
        }

        public SaveFileHeader Header { get; set; }
        public List<NodeEntry> Nodes;
        public int LastBlockOffset;
        public List<NodeEntry> FlatNodes; //flat structure
        public Guid Guid { get; }
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
            MappingHelper.LoadDumpedClasses();
            MappingHelper.LoadDumpedEnums();
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
            MappingHelper.LoadDumpedClasses();
            MappingHelper.LoadDumpedEnums();
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
                Header = new SaveFileHeader();
                Header.ReadSaveFileHeader(reader);
                int blockInfoStart = (int)reader.BaseStream.Position;
                reader.BaseStream.Seek(-8, SeekOrigin.End);
                LastBlockOffset = reader.ReadInt32();
                reader.BaseStream.Seek(LastBlockOffset, SeekOrigin.Begin);
                string edonMagic = reader.ReadString(4);
                var length = ParserUtils.ReadPackedLong(reader);
                for (int i = 0; i < length; i++)
                {
                    var name = ParserUtils.ReadString(reader);
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
                    node.Parsers = _parsers;
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
                ConnectNodeEvents(Nodes);
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
                    var parser = _parsers.FirstOrDefault(p => p.ParsableNodeName == node.Name);
                    if (parser == null)
                    {
                        parser = new DefaultParser();
                    }
                    stream.Write(parser.Write(node, _parsers));
                }
                uncompressedData = stream.ToArray();
            }

            // Recalculate all node offsets
            //Nodes.FirstOrDefault()?.MySizeChanged();
            RecalculateNodeOffsets(Nodes, 0);

            return uncompressedData;
        }

        private void RecalculateNodeOffsets(IEnumerable<NodeEntry> nodes, int offset)
        {
            foreach (var node in nodes)
            {
                /*
                var prevNode = node.GetPreviousNode();
                if (prevNode == null)
                {
                    // First node that is either a child node or not.
                    var parent = node.GetParent();
                    if (parent == null)
                    {
                        // Very first node, our offset does not change
                        // If I have children, these need to be changed, too
                        RecalculateNodeOffsets(node.Children, offset);
                    }
                    else
                    {
                        // First child node.
                        // Adjust my own size and offset
                        // If I have children, these need to be changed, too
                        node.Size += node.SizeChange;
                        RecalculateNodeOffsets(node.Children, offset);
                        node.Offset += offset;
                        offset += node.SizeChange;
                    }
                }
                else
                {
                    // Adjust my own size and offset
                    // If I have children, these need to be changed, too
                    node.Size += node.SizeChange;
                    RecalculateNodeOffsets(node.Children, offset);
                    node.Offset += offset;
                    offset += node.SizeChange;
                }
                */
                node.Size += node.SizeChange;
                node.Offset += offset;
                RecalculateNodeOffsets(node.Children, offset);
                offset += node.SizeChange;
                var prevNode = node.GetPreviousNode();
                if (prevNode != null)
                    Debug.Assert(prevNode.Offset + prevNode.Size <= node.Offset);
            }
        }

        private byte[] BuildHeader(List<Lz4Chunk> chunks)
        {
            byte[] result;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    Header.Write(writer);
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
                        ParserUtils.WriteString(writer, node.Name);
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
                    if (blobSize < 0)
                    {
                        throw new InvalidDataException("Found a datablob with negative size");
                    }
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
                    if (blobSize < 0)
                    {
                        throw new InvalidDataException("Found a datablob with negative size");
                    }
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

        private void ConnectNodeEvents(List<NodeEntry> nodes)
        {
            foreach (var node in nodes)
            {
                // Register myself at the previous node
                var prev = node.GetPreviousNode();
                if (prev != null)
                {
                    prev.NodeSizeChanged += node.OnPreviousNodeSizeChanged;
                    prev.NodeOffsetChanged += node.OnPreviousNodeOffsetChanged;
                }

                // I need to now if my parent offset changed, but only if I'm the first child
                var parent = node.GetParent();
                if (parent != null && node.IsFirstChild)
                {
                    parent.NodeOffsetChanged += node.OnParentNodeOffsetChanged;
                }

                // If I'm a child, I need to notify my parent if my size changes
                if (parent != null)
                {
                    node.ChildSizeChanged += parent.OnChildSizeChanged;
                }

                // Do the same for my children
                ConnectNodeEvents(node.Children);
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
