using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Forms.Classes
{
    class ParserConfig
    {
        [Browsable(false)]
        public INodeParser Parser { get; private set;}
        public string Name { get => Parser.DisplayName;}
        public bool Enabled { get; set; }
        public ParserConfig(INodeParser parser, bool enabled)
        {
            Parser = parser;
            Enabled = enabled;
        }
    }
}
