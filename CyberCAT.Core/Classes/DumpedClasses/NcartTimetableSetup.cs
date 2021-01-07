using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NcartTimetableSetup")]
    public class NcartTimetableSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("departFrequency")]
        [RealType("Int32")]
        public int DepartFrequency { get; set; }
        
        [RealName("uiUpdateFrequency")]
        [RealType("Int32")]
        public int UiUpdateFrequency { get; set; }
    }
}
