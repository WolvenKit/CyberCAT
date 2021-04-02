using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entEntity")]
    public class EntEntity : IScriptable
    {
        [RealName("customCameraTarget")]
        public DumpedEnums.ECustomCameraTarget? CustomCameraTarget { get; set; }
        
        [RealName("renderSceneLayerMask")]
        [RealType("RenderSceneLayerMask")]
        public dynamic RenderSceneLayerMask { get; set; }
    }
}
