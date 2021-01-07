using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("InvisibleSceneStashControllerPS")]
    public class InvisibleSceneStashControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("storedItems")]
        public GameItemID[] StoredItems { get; set; }
    }
}
