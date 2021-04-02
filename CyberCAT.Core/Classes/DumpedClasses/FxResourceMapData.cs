using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FxResourceMapData")]
    public class FxResourceMapData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("key")]
        public CName Key { get; set; }
        
        [RealName("resource")]
        public GameFxResource Resource { get; set; }
    }
}
