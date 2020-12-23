using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    public class DefaultParser
    {
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new DefaultRepresentation();
            if (node.Children.Count > 0)
            {
                foreach (var child in node.Children)
                {
                    var parser = parsers.Where(p => p.ParsableNodeName == child.Name).FirstOrDefault();
                    if (parser != null)
                    {
                        child.Value = parser.Read(child, reader,parsers);
                    }
                    else
                    {
                        var fallback = new DefaultParser();
                        child.Value = fallback.Read(child, reader, parsers);
                    }
                }
                //var sumOfChildSizes = 
                var sumOfChildSizes = node.Children.Sum(c => c.Size);
                if (sumOfChildSizes+4 < node.Size)//we need to add 4 to size because thats our ID and included in our size 
                {
                    var readSize = node.Size - sumOfChildSizes;
                    if ((node.Children[0].Offset - node.Offset) > 4)
                    {
                        //We need to read out Data for this block infront
                        reader.BaseStream.Position = node.Offset;
                        reader.ReadInt32();//dont store Id for now
                        result.Blob = reader.ReadBytes(readSize - 4);
                        var nextNode = node.GetNextNode();
                    }
                    else
                    {
                        Debugger.Break();//Dont know what to do here
                    }
                }
            }
            else
            {
                reader.BaseStream.Position = node.Offset;
                reader.ReadInt32();//dont store Id for now
                result.Blob = reader.ReadBytes(node.Size-4);
                
            }
            return result;
        }
        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            node.Size = 0;
            var data = (DefaultRepresentation)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    if (node.Children.Count > 0)
                    {
                        if (data.Blob != null)
                        {
                            writer.Write(data.Blob);
                        }
                        foreach (var child in node.Children)
                        {
                            var parser = parsers.Where(p => p.ParsableNodeName == child.Name).FirstOrDefault();
                            if (parser != null)
                            {
                                writer.Write(parser.Write(child, parsers));
                            }
                            else
                            {
                                var fallback = new DefaultParser();
                                writer.Write(fallback.Write(child, parsers));
                            }
                        }
                    }
                    else
                    {
                        if (data != null)
                        {
                            writer.Write(data.Blob);

                        }
                    }
                }
                result = stream.ToArray();
            }
            //we are recalculating the size while writing
            node.Size += result.Length;
            if (node.Size == 4)//dont have their ID written
            {
                result = new byte[4];
            }
            return result;
        }
    }
}
