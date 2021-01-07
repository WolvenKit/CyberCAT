using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SPreventionAgentData")]
    public class SPreventionAgentData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
        
        [RealName("position")]
        public Vector4 Position { get; set; }
    }
}
