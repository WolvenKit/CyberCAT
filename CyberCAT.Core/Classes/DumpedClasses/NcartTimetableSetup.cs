using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NcartTimetableSetup")]
    public class NcartTimetableSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("departFrequency")]
        public int DepartFrequency { get; set; }
        
        [RealName("uiUpdateFrequency")]
        public int UiUpdateFrequency { get; set; }
    }
}
