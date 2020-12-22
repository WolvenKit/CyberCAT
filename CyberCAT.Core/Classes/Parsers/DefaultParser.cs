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
                var sumOfChildSizes = node.Children.Sum(c => c.Size);
                if (sumOfChildSizes + 4 < node.Size)
                {
                    reader.BaseStream.Position = node.Offset;
                    node.Id = reader.ReadInt32();
                    //reader.Skip(4);//skip Id TODO maybe store later
                    var readSize = node.Size - 4 - sumOfChildSizes;
                    result.Blob = reader.ReadBytes(readSize);
                    Debug.Assert((node.Offset + sumOfChildSizes + result.Blob.Length + 4) == node.GetNextNode().Offset);//If not we have misread the structure somehow
                }
                
            }
            else
            {
                reader.BaseStream.Position = node.Offset;
                //reader.Skip(4);//skip Id TODO maybe store later
                node.Id = reader.ReadInt32();
                result.Blob = reader.ReadBytes(node.Size-4);
                
            }
            return result;

        }
    }
}
