using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIPatrolPathParameters")]
    public class AIPatrolPathParameters : IScriptable
    {
        [RealName("path")]
        public NodeRef Path { get; set; }

        [RealName("movementType")]
        public DumpedEnums.moveMovementType? MovementType { get; set; }

        [RealName("enterClosest")]
        public bool EnterClosest { get; set; }

        [RealName("patrolWithWeapon")]
        public bool PatrolWithWeapon { get; set; }

        [RealName("isBackAndForth")]
        public bool IsBackAndForth { get; set; }

        [RealName("isInfinite")]
        public bool IsInfinite { get; set; }

        [RealName("numberOfLoops")]
        public uint NumberOfLoops { get; set; }

        [RealName("sortPatrolPoints")]
        public bool SortPatrolPoints { get; set; }

        [RealName("patrolAction")]
        public TweakDbId PatrolAction { get; set; }
        
        public AIPatrolPathParameters()
        {
            IsInfinite = true;
            EnterClosest = true;
            SortPatrolPoints = true;
            // TODO: Verify this
            NumberOfLoops = 1;
        }
    }
}
