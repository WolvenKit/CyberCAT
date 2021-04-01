using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SWeaponPlaneParams")]
    public class SWeaponPlaneParams : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("weaponNearPlaneCM")]
        public float WeaponNearPlaneCM { get; set; }
        
        [RealName("blurIntensity")]
        public float BlurIntensity { get; set; }
    }
}
