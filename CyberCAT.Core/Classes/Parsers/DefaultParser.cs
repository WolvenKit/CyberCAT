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
            }

            reader.BaseStream.Position = node.Offset;
            result.Blob = reader.ReadBytes(node.TrueSize);
                
            return result;
        }
        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (DefaultRepresentation)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
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
            if (node.TrueSize == 0)//dont have their ID written
            {
                result = new byte[4];
            }
            return result;
        }
    }
}
