using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("C2dArray")]
    public class C2dArray : CResource
    {
        [RealName("headers")]
        public string[] Headers { get; set; }
        
        [RealName("data")]
        public string[] Data { get; set; }
    }
}
