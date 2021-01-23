using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SoundSystemSettings")]
    public class SoundSystemSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("interactionName")]
        public TweakDbId InteractionName { get; set; }
        
        [RealName("musicSettings")]
        public Handle<MusicSettings> MusicSettings { get; set; }
        
        [RealName("canBeUsedAsQuickHack")]
        public bool CanBeUsedAsQuickHack { get; set; }
    }
}
