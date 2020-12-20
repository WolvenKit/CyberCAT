using CyberCAT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public class SaveFileParser
    {

        List<ISectionParser> _parsers;
        Stack<byte> _readHistory;
         public SaveFileParser()
        {
            _parsers = new List<ISectionParser>();
            _parsers.Add(new AppearanceSectionParser());
            _readHistory = new Stack<byte>();
            
        }
        public List<string> Parse(Stream inputStream)
        {
            var result = new List<string>();
            inputStream.Seek(0, SeekOrigin.Begin);
            using (BinaryReader reader = new BinaryReader(inputStream, Encoding.ASCII))
            {
                while (reader.BaseStream.Position<reader.BaseStream.Length)
                {
                    _readHistory.Push(reader.ReadByte());
                    foreach (var parser in _parsers)
                    {
                        if (parser.IsTriggered(_readHistory))
                        {
                            parser.Parse(inputStream);
                            break;
                        }
                    }
                }
                foreach(var parser in _parsers)
                {
                    result.Add(parser.Json);
                }
            }
            return result;
        }
    }
}
