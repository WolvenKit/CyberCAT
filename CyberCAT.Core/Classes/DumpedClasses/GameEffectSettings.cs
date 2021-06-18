using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectSettings")]
    public class GameEffectSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("advancedTargetHandling")]
        public bool AdvancedTargetHandling { get; set; }
        
        [RealName("synchronousProcessingForPlayer")]
        public bool SynchronousProcessingForPlayer { get; set; }
        
        [RealName("forceSynchronousProcessing")]
        public bool ForceSynchronousProcessing { get; set; }
        
        [RealName("tempExecuteOnlyOnce")]
        public bool TempExecuteOnlyOnce { get; set; }

        [RealName("tickRate")]
        public float TickRate { get; set; }

        [RealName("useSimTimeForTick")]
        public bool UseSimTimeForTick { get; set; }
    }
}
