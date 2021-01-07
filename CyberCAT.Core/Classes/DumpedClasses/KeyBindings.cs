using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("KeyBindings")]
    public class KeyBindings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("DPAD_UP")]
        [RealType("TweakDBID")]
        public TweakDbId DPAD_UP { get; set; }
        
        [RealName("RB")]
        [RealType("TweakDBID")]
        public TweakDbId RB { get; set; }
    }
}
