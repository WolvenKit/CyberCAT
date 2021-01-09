using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EntityAttachementComponentPS")]
    public class EntityAttachementComponentPS : GameComponentPS
    {
        [RealName("pendingChildAttachements")]
        public EntityAttachementData[] PendingChildAttachements { get; set; }
    }
}
