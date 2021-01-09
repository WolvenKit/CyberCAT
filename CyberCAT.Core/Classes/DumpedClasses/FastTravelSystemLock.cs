using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FastTravelSystemLock")]
    public class FastTravelSystemLock : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("lockReason")]
        [RealType("CName")]
        public string LockReason { get; set; }
        
        [RealName("linkedStatusEffectID")]
        [RealType("TweakDBID")]
        public TweakDbId LinkedStatusEffectID { get; set; }
    }
}
