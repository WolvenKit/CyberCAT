using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceActionProperty")]
    public class GamedeviceActionProperty : IScriptable
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("typeName")]
        public CName TypeName { get; set; }

        // TODO: Check type
        [RealName("first")]
        [RealType("Variant")]
        public dynamic First { get; set; }

        // TODO: Check type
        [RealName("second")]
        [RealType("Variant")]
        public dynamic Second { get; set; }

        // TODO: Check type
        [RealName("third")]
        [RealType("Variant")]
        public dynamic Third { get; set; }
        
        [RealName("flags")]
        public DumpedEnums.gamedeviceActionPropertyFlags? Flags { get; set; }
    }
}
