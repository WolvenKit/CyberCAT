using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkStyleResource")]
    public class InkStyleResource : CResource
    {
        [RealName("styles")]
        public InkStyle[] Styles { get; set; }
        
        [RealName("themes")]
        public InkStyleTheme[] Themes { get; set; }
        
        [RealName("styleImports")]
        public InkStyleResource[] StyleImports { get; set; }
        
        [RealName("hideInInheritingStyles")]
        public bool HideInInheritingStyles { get; set; }
    }
}
