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
        List<NodeEntry> _nodes = new List<NodeEntry>();//flat structure
        List<INodeParser> _parsers;
        public SaveFile()
        {
            Nodes = new List<NodeEntry>();
            //TODO do this with dependency injection or Reflection and a Plugin type DLL Folder
            _parsers = new List<INodeParser>();
            _parsers.Add(new GameSessionConfigParser());
        }
        public void Load(Stream inputStream)
        {
            _nodes = new List<NodeEntry>();
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
                    _nodes.Add(entry);
                }
            }
            inputStream.Seek(0, SeekOrigin.Begin);
            var activeSaveFile = new SaveFileCompressionHelper();
            var decompressedFile = activeSaveFile.Decompress(inputStream);
            using (MemoryStream memoryStream = new MemoryStream(decompressedFile))
            {
                using (BinaryReader reader = new BinaryReader(memoryStream, Encoding.ASCII))
                {

                    foreach (var node in _nodes)
                    {
                        reader.BaseStream.Position = node.Offset;
                        node.Id = reader.ReadInt32();
                    }
                    foreach (var node in _nodes)
                    {
                        if (!node.IsChild)
                        {
                            FindChildren(_nodes, node);
                        }
                        if (node.NextId > -1)
                        {
                            node.SetNextNode(_nodes.Where(n => n.Id == node.NextId).FirstOrDefault());
                        }
                    }
                    Nodes.AddRange(_nodes.Where(n => !n.IsChild));
                    foreach (var node in Nodes)
                    {
                        var parser = _parsers.Where(p => p.ParsableNodeName == node.Name).FirstOrDefault();
                        if (parser != null)
                        {
                            node.Value = parser.Read(node, reader, _parsers);
                        }
                        else
                        {
                            var fallback = new DefaultParser();
                            node.Value = fallback.Read(node, reader, _parsers);
                        }
                    }
                }
            }
            Save();
        }
        private void Save()
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
            foreach (var node in Nodes)
            {
                RecalculateOffsets(node);
            }
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
                    writer.Write(Constants.Magic.END_OF_FILE);
                }
                result = stream.ToArray();
            }
            File.WriteAllBytes($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\output.bin", uncompressedData);

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
            using(var stream = new MemoryStream())
            {
                using(var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(Encoding.ASCII.GetBytes(Constants.Magic.NODE_INFORMATION_START));
                    writer.WriteBit6(_nodes.Count);
                    foreach (var node in _nodes)
                    {
                        writer.Write((byte)(node.Name.Length+128));
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
        void RecalculateOffsets(NodeEntry node)
        {
            if (node != null)
            {
                if (node.Id == 0)
                {
                    node.Offset = Constants.Numbers.DEFAULT_HEADER_SIZE;//TODO analyse if this is really fixed
                }
                else
                {
                    if (node.ChildId > -1)
                    {
                        var child = Nodes.Where(n => n.Id == node.ChildId).FirstOrDefault();
                        RecalculateOffsets(child);
                    }
                    var previousNode = node.GetPreviousNode();
                    node.Offset = previousNode.Offset + previousNode.Size;
                }
            }
        }
        void WriteNode(NodeEntry node, BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
        private void FindChildren(List<NodeEntry> nodes, NodeEntry node)
        {
            if (node.ChildId > -1)
            {
                var nextId = node.NextId;
                if (nextId == -1)
                {
                    nextId = nodes.Count;
                }
                for (int i = node.ChildId; i < nextId; i++)
                {
                    var possibleChild = nodes.Where(n => n.Id == i).FirstOrDefault();
                    possibleChild.IsChild = true;
                    if (possibleChild.ChildId > -1)//SubChild
                    {
                        FindChildren(nodes, possibleChild);
                    }
                    else
                    {
                        node.Children.Add(possibleChild);
                    }

                }
            }
        }
    }
}
