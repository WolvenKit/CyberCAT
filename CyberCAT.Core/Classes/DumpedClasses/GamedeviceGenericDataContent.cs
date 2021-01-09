using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceGenericDataContent")]
    public class GamedeviceGenericDataContent : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("name")]
        [RealType("String")]
        public string Name { get; set; }
        
        [RealName("content")]
        public GamedeviceDataElement[] Content { get; set; }
    }
}
