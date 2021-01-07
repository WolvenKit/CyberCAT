using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ChangeMusicAction")]
    public class ChangeMusicAction : ActionBool
    {
        [RealName("interactionRecordName")]
        [RealType("String")]
        public string InteractionRecordName { get; set; }
        
        [RealName("settings")]
        public Handle<MusicSettings> Settings { get; set; }
    }
}
