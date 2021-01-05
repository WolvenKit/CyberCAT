
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("CResource")]
    public class CResource : ISerializable
    {
        [RealName("cookingPlatform")]
        public DumpedEnums.ECookingPlatform? CookingPlatform { get; set; }
    }
}
