using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("handle")]
    public class Handle : GenericUnknownStruct.BaseClassEntry
    {
        public uint Pointer { get; set; }

        [ParserIgnore]
        public GenericUnknownStruct.BaseClassEntry ClassEntry {
            get
            {
                return null;
            }
        }
    }
}