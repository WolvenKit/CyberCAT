using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EditableGameLightSettings")]
    public class EditableGameLightSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("componentName")]
        public CName ComponentName { get; set; }
        
        [RealName("strength")]
        public float Strength { get; set; }
        
        [RealName("modifyStrength")]
        public bool ModifyStrength { get; set; }
        
        [RealName("intensity")]
        public float Intensity { get; set; }
        
        [RealName("modifyIntensity")]
        public bool ModifyIntensity { get; set; }
        
        [RealName("radius")]
        public float Radius { get; set; }
        
        [RealName("modifyRadius")]
        public bool ModifyRadius { get; set; }
        
        [RealName("color")]
        public Color Color { get; set; }
        
        [RealName("modifyColor")]
        public bool ModifyColor { get; set; }
        
        [RealName("innerAngle")]
        public float InnerAngle { get; set; }
        
        [RealName("modifyInnerAngle")]
        public bool ModifyInnerAngle { get; set; }
        
        [RealName("outerAngle")]
        public float OuterAngle { get; set; }
        
        [RealName("modifyOuterAngle")]
        public bool ModifyOuterAngle { get; set; }
    }
}
