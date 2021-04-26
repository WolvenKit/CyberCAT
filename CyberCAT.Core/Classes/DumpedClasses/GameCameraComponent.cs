using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameCameraComponent")]
    public class GameCameraComponent : EntBaseCameraComponent
    {
        [RealName("weaponPlane")]
        public SWeaponPlaneParams WeaponPlane { get; set; }
        
        [RealName("animParamFovOverrideWeight")]
        public CName AnimParamFovOverrideWeight { get; set; }
        
        [RealName("animParamFovOverrideValue")]
        public CName AnimParamFovOverrideValue { get; set; }
        
        [RealName("animParamZoomOverrideWeight")]
        public CName AnimParamZoomOverrideWeight { get; set; }
        
        [RealName("animParamZoomOverrideValue")]
        public CName AnimParamZoomOverrideValue { get; set; }
        
        [RealName("animParamZoomWeaponOverrideWeight")]
        public CName AnimParamZoomWeaponOverrideWeight { get; set; }
        
        [RealName("animParamZoomWeaponOverrideValue")]
        public CName AnimParamZoomWeaponOverrideValue { get; set; }
        
        [RealName("animParamdofIntensity")]
        public CName AnimParamdofIntensity { get; set; }
        
        [RealName("animParamdofNearBlur")]
        public CName AnimParamdofNearBlur { get; set; }
        
        [RealName("animParamdofNearFocus")]
        public CName AnimParamdofNearFocus { get; set; }
        
        [RealName("animParamdofFarBlur")]
        public CName AnimParamdofFarBlur { get; set; }
        
        [RealName("animParamdofFarFocus")]
        public CName AnimParamdofFarFocus { get; set; }
        
        [RealName("animParamWeaponNearPlaneCM")]
        public CName AnimParamWeaponNearPlaneCM { get; set; }
        
        [RealName("animParamWeaponFarPlaneCM")]
        public CName AnimParamWeaponFarPlaneCM { get; set; }
        
        [RealName("animParamWeaponEdgesSharpness")]
        public CName AnimParamWeaponEdgesSharpness { get; set; }
        
        [RealName("animParamWeaponVignetteIntensity")]
        public CName AnimParamWeaponVignetteIntensity { get; set; }
        
        [RealName("animParamWeaponVignetteRadius")]
        public CName AnimParamWeaponVignetteRadius { get; set; }
        
        [RealName("animParamWeaponVignetteCircular")]
        public CName AnimParamWeaponVignetteCircular { get; set; }
        
        [RealName("animParamWeaponBlurIntensity")]
        public CName AnimParamWeaponBlurIntensity { get; set; }
        
        [RealName("fovOverrideWeight")]
        public float FovOverrideWeight { get; set; }
        
        [RealName("fovOverrideValue")]
        public float FovOverrideValue { get; set; }
        
        [RealName("zoomOverrideWeight")]
        public float ZoomOverrideWeight { get; set; }
        
        [RealName("zoomOverrideValue")]
        public float ZoomOverrideValue { get; set; }
        
        [RealName("zoomWeaponOverrideWeight")]
        public float ZoomWeaponOverrideWeight { get; set; }
        
        [RealName("zoomWeaponOverrideValue")]
        public float ZoomWeaponOverrideValue { get; set; }
    }
}
