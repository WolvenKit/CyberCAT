using CyberCAT.Core.ChunkedLz4;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.Parsers;
using System;
using System.Collections.Generic;
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
        public Guid DumpGuid;
        List<INodeParser> _parsers;
        public SaveFile()
        {
            DumpGuid = Guid.NewGuid();
            Nodes = new List<NodeEntry>();
            //TODO do this with dependency injection or Reflection and a Plugin type DLL Folder
            _parsers = new List<INodeParser>();
            _parsers.Add(new GameSessionConfigParser());
        }
        public void Load(Stream inputStream)
        {
            var tempNodes = new List<NodeEntry>(Nodes);
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
                    var tmpFlags = new Flags(reader);
                    string name = reader.ReadString(tmpFlags.Length);
                    var entry = new NodeEntry();
                    entry.NextId = reader.ReadInt32();
                    entry.ChildId = reader.ReadInt32();
                    entry.Offset = reader.ReadInt32();
                    entry.Size = reader.ReadInt32();
                    entry.Name = name;
                    tempNodes.Add(entry);
                }
            }
            inputStream.Seek(0, SeekOrigin.Begin);
            var activeSaveFile = new SaveFileCompressionHelper();
            var decompressedFile = activeSaveFile.Decompress(inputStream);
            using (MemoryStream memoryStream = new MemoryStream(decompressedFile))
            {
                using (BinaryReader reader = new BinaryReader(memoryStream, Encoding.ASCII))
                {

                    foreach (var node in tempNodes)
                    {
                        reader.BaseStream.Position = node.Offset;
                        node.Id = reader.ReadInt32();
                    }
                    foreach (var node in tempNodes)
                    {
                        if (!node.IsChild)
                        {
                            FindChildren(tempNodes, node);
                        }
                        if (node.NextId > -1)
                        {
                            node.SetNextNode(tempNodes.Where(n => n.Id == node.NextId).FirstOrDefault());
                        }
                    }
                    Nodes.AddRange(tempNodes.Where(n => !n.IsChild));
                    foreach(var node in Nodes)
                    {
                        var parser = _parsers.Where(p => p.ParsableNodeName == node.Name).FirstOrDefault();
                        if (parser != null)
                        {
                            node.Value = parser.Read(node, reader,_parsers);
                        }
                        else
                        {
                            var fallback = new DefaultParser();
                            node.Value = fallback.Read(node, reader, _parsers);
                        }
                    }
                }
            }
            
        }
        private void Save()
        {
            throw new NotImplementedException();
        }
        private void FindChildren(List<NodeEntry> nodes, NodeEntry node)
        {
            if (node.ChildId > -1)
            {
                var counter = node.ChildId;
                for(int i =node.ChildId; i<node.NextId;i++)
                {
                    var possibleChild = nodes.Where(n => n.Id == counter).FirstOrDefault();
                    possibleChild.IsChild = true;
                    if (possibleChild.ChildId > -1)//SubChild
                    {
                        FindChildren(nodes, possibleChild);
                    }
                    else
                    {
                        node.Children.Add(possibleChild);
                    }
                    counter++;

                }
            }
        }
    }
}
