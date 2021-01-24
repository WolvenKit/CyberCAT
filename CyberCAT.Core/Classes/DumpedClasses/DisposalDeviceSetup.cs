using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DisposalDeviceSetup")]
    public class DisposalDeviceSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("numberOfUses")]
        public int NumberOfUses { get; set; }
        
        [RealName("isBodyRequired")]
        public bool IsBodyRequired { get; set; }
        
        [RealName("actionName")]
        public TweakDbId ActionName { get; set; }
        
        [RealName("takedownActionName")]
        public TweakDbId TakedownActionName { get; set; }
        
        [RealName("nonlethalTakedownActionName")]
        public TweakDbId NonlethalTakedownActionName { get; set; }

        public DisposalDeviceSetup()
        {
            // TODO: Verify this
            NumberOfUses = 1;
        }
    }
}
