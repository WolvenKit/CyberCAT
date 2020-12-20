using CyberCAT.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Interfaces
{
    interface ISaveFileSection
    {
        SaveFileSectionType Type { get; set; }
        /// <summary>
        /// Writes the section to the buffer at given position
        /// </summary>
        /// <param name="buffer">Buffer to write to</param>
        /// <param name="position">Position to start writing</param>
        /// <returns></returns>
        byte[] WriteToBuffer(byte[] buffer, int position);
        string GetJson();
    }
}
