using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CResource")]
    public class CResource : ISerializable
    {
        [RealName("cookingPlatform")]
        public DumpedEnums.ECookingPlatform? CookingPlatform { get; set; }
    }
}
