using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entTransformHistoryComponent")]
    public class EntTransformHistoryComponent : EntIComponent
    {
        [RealName("historyLength")]
        public float HistoryLength { get; set; }
        
        [RealName("samplesAmount")]
        public uint SamplesAmount { get; set; }
    }
}
