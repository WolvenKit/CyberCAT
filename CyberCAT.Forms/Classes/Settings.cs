using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Forms.Classes
{
    class Settings
    {
        public List<Guid> EnabledParsers {get; set;}
        public Settings()
        {
            EnabledParsers = new List<Guid>();
        }
    }
}
