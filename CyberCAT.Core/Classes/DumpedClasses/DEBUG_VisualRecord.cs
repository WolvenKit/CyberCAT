using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DEBUG_VisualRecord")]
    public class DEBUG_VisualRecord : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("layerIDs")]
        public uint[] LayerIDs { get; set; }
        
        [RealName("puppet")]
        public ScriptedPuppet Puppet { get; set; }
        
        [RealName("infiniteDuration")]
        public bool InfiniteDuration { get; set; }
        
        [RealName("showDuration")]
        public float ShowDuration { get; set; }
    }
}
