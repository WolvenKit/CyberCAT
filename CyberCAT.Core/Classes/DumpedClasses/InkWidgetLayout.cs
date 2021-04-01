using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkWidgetLayout")]
    public class InkWidgetLayout : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("padding")]
        public InkMargin Padding { get; set; }
        
        [RealName("margin")]
        public InkMargin Margin { get; set; }
        
        [RealName("anchorPoint")]
        public Vector2 AnchorPoint { get; set; }
        
        [RealName("sizeCoefficient")]
        public float SizeCoefficient { get; set; }
        
        [RealName("HAlign")]
        public DumpedEnums.inkEHorizontalAlign? HAlign { get; set; }
        
        [RealName("VAlign")]
        public DumpedEnums.inkEVerticalAlign? VAlign { get; set; }
        
        [RealName("anchor")]
        public DumpedEnums.inkEAnchor? Anchor { get; set; }
        
        [RealName("sizeRule")]
        public DumpedEnums.inkESizeRule? SizeRule { get; set; }
    }
}
