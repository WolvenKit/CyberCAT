using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEntityStubComponentPS")]
    public class GameEntityStubComponentPS : GameComponentPS
    {
        [RealName("entityLocalPosition")]
        public Vector3 EntityLocalPosition { get; set; }
        
        [RealName("entityLocalRotation")]
        public Quaternion EntityLocalRotation { get; set; }
        
        [RealName("spawnerId")]
        public GameCommunityID SpawnerId { get; set; }
        
        [RealName("ownerCommunityEntryName")]
        [RealType("CName")]
        public string OwnerCommunityEntryName { get; set; }
        
        [RealName("selectedAppearanceName")]
        [RealType("CName")]
        public string SelectedAppearanceName { get; set; }
    }
}
