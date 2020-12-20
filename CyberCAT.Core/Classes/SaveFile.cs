using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public class SaveFile
    {
        /// <summary>
        /// First Unknown Length
        /// </summary>
        public int FirstLength;
        /// <summary>
        /// Second Unknown Length
        /// </summary>
        public int SecondLength;
        /// <summary>
        /// First Hash. Seems to be handled special
        /// </summary>
        public ulong FirstSpecialHash;
        public ulong SecondSpecialHash;
        public IReadOnlyCollection<AppearanceSectionEntry> AppearanceEntries
        {
            get
            {
                return _entries.AsReadOnly();
            }
        }
        private List<AppearanceSectionEntry> _entries;

        public SaveFile()
        {
            _entries = new List<AppearanceSectionEntry>();
        }
        public void AddEntry(AppearanceSectionEntry entryToAdd)
        {
            _entries.Add(entryToAdd);
        }

        public void AddEntries(List<AppearanceSectionEntry> entries)
        {
            _entries.AddRange(entries);
        }

    }
}
