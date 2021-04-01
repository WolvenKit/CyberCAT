using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkStyleTheme")]
    public class InkStyleTheme : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("styleResource")]
        public InkStyleResource StyleResource { get; set; }
        
        [RealName("themeID")]
        public CName ThemeID { get; set; }
    }
}
