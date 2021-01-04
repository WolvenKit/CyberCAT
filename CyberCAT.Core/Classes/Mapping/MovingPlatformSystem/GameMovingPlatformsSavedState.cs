using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.MovingPlatformSystem
{
    [RealName("gameMovingPlatformsSavedState")]
    public class GameMovingPlatformsSavedState : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("mapping")]
        public EntEntityID[] Mapping { get; set; }

        [RealName("data")]
        public GameMovingPlatformSavedData[] Data { get; set; }
    }
}