using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animActionAnimDatabase")]
    public class AnimActionAnimDatabase : CResource
    {
        [RealName("rows")]
        public AnimActionAnimDatabase_DatabaseRow[] Rows { get; set; }
    }
}
