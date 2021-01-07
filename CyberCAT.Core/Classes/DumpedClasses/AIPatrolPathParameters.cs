using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIPatrolPathParameters")]
    public class AIPatrolPathParameters : IScriptable
    {
        [RealName("path")]
        [RealType("NodeRef")]
        public string Path { get; set; }
        
        [RealName("movementType")]
        public DumpedEnums.moveMovementType? MovementType { get; set; }
        
        [RealName("enterClosest")]
        [RealType("Bool")]
        public bool EnterClosest { get; set; }
        
        [RealName("patrolWithWeapon")]
        [RealType("Bool")]
        public bool PatrolWithWeapon { get; set; }
        
        [RealName("isBackAndForth")]
        [RealType("Bool")]
        public bool IsBackAndForth { get; set; }
        
        [RealName("isInfinite")]
        [RealType("Bool")]
        public bool IsInfinite { get; set; }
        
        [RealName("numberOfLoops")]
        [RealType("Uint32")]
        public uint NumberOfLoops { get; set; }
        
        [RealName("sortPatrolPoints")]
        [RealType("Bool")]
        public bool SortPatrolPoints { get; set; }
        
        [RealName("patrolAction")]
        [RealType("TweakDBID")]
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
