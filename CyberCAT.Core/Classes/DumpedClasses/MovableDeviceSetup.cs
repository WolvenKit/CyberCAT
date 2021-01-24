using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MovableDeviceSetup")]
    public class MovableDeviceSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("numberOfUses")]
        public int NumberOfUses { get; set; }

        public MovableDeviceSetup()
        {
            // TODO: Verify this
            NumberOfUses = 1;
        }
    }
}
