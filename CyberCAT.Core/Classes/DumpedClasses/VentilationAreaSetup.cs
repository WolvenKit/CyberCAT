using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VentilationAreaSetup")]
    public class VentilationAreaSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaEffect")]
        public DumpedEnums.ETrapEffects? AreaEffect { get; set; }
        
        [RealName("actionName")]
        [RealType("CName")]
        public string ActionName { get; set; }
    }
}
