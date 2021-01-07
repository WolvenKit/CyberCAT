using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VendingMachineSetup")]
    public class VendingMachineSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("timeToCompletePurchase")]
        [RealType("Float")]
        public float TimeToCompletePurchase { get; set; }
    }
}
