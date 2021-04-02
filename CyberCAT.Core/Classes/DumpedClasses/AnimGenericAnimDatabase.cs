using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animGenericAnimDatabase")]
    public class AnimGenericAnimDatabase : CResource
    {
        [RealName("rows")]
        public AnimGenericAnimDatabase_DatabaseRow[] Rows { get; set; }
    }
}
