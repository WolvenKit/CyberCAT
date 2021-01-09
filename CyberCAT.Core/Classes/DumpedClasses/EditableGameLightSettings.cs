using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EditableGameLightSettings")]
    public class EditableGameLightSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("componentName")]
        [RealType("CName")]
        public string ComponentName { get; set; }
        
        [RealName("strength")]
        [RealType("Float")]
        public float Strength { get; set; }
        
        [RealName("modifyStrength")]
        [RealType("Bool")]
        public bool ModifyStrength { get; set; }
        
        [RealName("intensity")]
        [RealType("Float")]
        public float Intensity { get; set; }
        
        [RealName("modifyIntensity")]
        [RealType("Bool")]
        public bool ModifyIntensity { get; set; }
        
        [RealName("radius")]
        [RealType("Float")]
        public float Radius { get; set; }
        
        [RealName("modifyRadius")]
        [RealType("Bool")]
        public bool ModifyRadius { get; set; }
        
        [RealName("color")]
        public Color Color { get; set; }
        
        [RealName("modifyColor")]
        [RealType("Bool")]
        public bool ModifyColor { get; set; }
        
        [RealName("innerAngle")]
        [RealType("Float")]
        public float InnerAngle { get; set; }
        
        [RealName("modifyInnerAngle")]
        [RealType("Bool")]
        public bool ModifyInnerAngle { get; set; }
        
        [RealName("outerAngle")]
        [RealType("Float")]
        public float OuterAngle { get; set; }
        
        [RealName("modifyOuterAngle")]
        [RealType("Bool")]
        public bool ModifyOuterAngle { get; set; }
    }
}
