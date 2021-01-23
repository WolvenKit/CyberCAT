using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FastTravelSystemLock")]
    public class FastTravelSystemLock : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("lockReason")]
        public CName LockReason { get; set; }
        
        [RealName("linkedStatusEffectID")]
        public TweakDbId LinkedStatusEffectID { get; set; }
    }
}
