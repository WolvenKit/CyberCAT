using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
