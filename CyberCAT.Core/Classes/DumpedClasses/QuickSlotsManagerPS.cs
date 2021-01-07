using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("QuickSlotsManagerPS")]
    public class QuickSlotsManagerPS : GameComponentPS
    {
        [RealName("activeVehicleType")]
        public DumpedEnums.gamedataVehicleType? ActiveVehicleType { get; set; }
    }
}
