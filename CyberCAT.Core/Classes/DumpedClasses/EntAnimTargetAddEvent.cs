using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entAnimTargetAddEvent")]
    public class EntAnimTargetAddEvent : RedEvent
    {
        [RealName("targetPositionProvider")]
        public Handle<EntIPositionProvider> TargetPositionProvider { get; set; }
        
        [RealName("bodyPart")]
        public CName BodyPart { get; set; }
    }
}
