using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DisposalDeviceSetup")]
    public class DisposalDeviceSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("numberOfUses")]
        [RealType("Int32")]
        public int NumberOfUses { get; set; }
        
        [RealName("isBodyRequired")]
        [RealType("Bool")]
        public bool IsBodyRequired { get; set; }
        
        [RealName("actionName")]
        [RealType("TweakDBID")]
        public TweakDbId ActionName { get; set; }
        
        [RealName("takedownActionName")]
        [RealType("TweakDBID")]
        public TweakDbId TakedownActionName { get; set; }
        
        [RealName("nonlethalTakedownActionName")]
        [RealType("TweakDBID")]
        public TweakDbId NonlethalTakedownActionName { get; set; }
    }
}
