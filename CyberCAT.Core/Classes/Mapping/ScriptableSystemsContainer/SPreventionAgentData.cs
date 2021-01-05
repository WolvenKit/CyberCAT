using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
