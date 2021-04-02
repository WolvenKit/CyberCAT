using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEntityStubComponentPS")]
    public class GameEntityStubComponentPS : GameComponentPS
    {
        [RealName("entityLocalRotation")]
        public Quaternion EntityLocalRotation { get; set; }
        
        [RealName("entityLocalPosition")]
        public Vector3 EntityLocalPosition { get; set; }
        
        [RealName("spawnerId")]
        public GameCommunityID SpawnerId { get; set; }
        
        [RealName("ownerCommunityEntryName")]
        public CName OwnerCommunityEntryName { get; set; }
        
        [RealName("selectedAppearanceName")]
        public CName SelectedAppearanceName { get; set; }
    }
}
