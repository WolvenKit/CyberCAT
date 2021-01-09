using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectSettings")]
    public class GameEffectSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("advancedTargetHandling")]
        [RealType("Bool")]
        public bool AdvancedTargetHandling { get; set; }
        
        [RealName("synchronousProcessingForPlayer")]
        [RealType("Bool")]
        public bool SynchronousProcessingForPlayer { get; set; }
        
        [RealName("forceSynchronousProcessing")]
        [RealType("Bool")]
        public bool ForceSynchronousProcessing { get; set; }
        
        [RealName("tempExecuteOnlyOnce")]
        [RealType("Bool")]
        public bool TempExecuteOnlyOnce { get; set; }
    }
}
