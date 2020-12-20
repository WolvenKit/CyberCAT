using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Interfaces
{
    interface ISectionParser
    {
        /// <summary>
        /// Checks the current buffer has Triggers for this Parser at the end
        /// </summary>
        /// <param name="inputStream">The Stream to Check</param>
        /// <returns></returns>
        bool IsTriggered(Stack<byte> readHistory);
        bool Parse(Stream inputStream);
        string Json { get; set; }

    }
}
