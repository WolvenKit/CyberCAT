using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DeviceLink")]
    public class DeviceLink : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("PSID")]
        public GamePersistentID PSID { get; set; }
        
        [RealName("className")]
        [RealType("CName")]
        public string ClassName { get; set; }
    }
}
