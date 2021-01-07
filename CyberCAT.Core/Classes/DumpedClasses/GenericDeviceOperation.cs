using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GenericDeviceOperation")]
    public class GenericDeviceOperation : DeviceOperationBase
    {
        [RealName("fxInstances")]
        public SVfxInstanceData[] FxInstances { get; set; }
        
        [RealName("transformAnimations")]
        public STransformAnimationData[] TransformAnimations { get; set; }
        
        [RealName("VFXs")]
        public SVFXOperationData[] VFXs { get; set; }
        
        [RealName("SFXs")]
        public SSFXOperationData[] SFXs { get; set; }
        
        [RealName("facts")]
        public SFactOperationData[] Facts { get; set; }
        
        [RealName("components")]
        public SComponentOperationData[] Components { get; set; }
        
        [RealName("stims")]
        public SStimOperationData[] Stims { get; set; }
        
        [RealName("statusEffects")]
        public SStatusEffectOperationData[] StatusEffects { get; set; }
        
        [RealName("damages")]
        public SDamageOperationData[] Damages { get; set; }
        
        [RealName("items")]
        public SInventoryOperationData[] Items { get; set; }
        
        [RealName("teleport")]
        public STeleportOperationData Teleport { get; set; }
        
        [RealName("meshesAppearence")]
        [RealType("CName")]
        public string MeshesAppearence { get; set; }
        
        [RealName("playerWorkspot")]
        public SWorkspotData PlayerWorkspot { get; set; }
    }
}
