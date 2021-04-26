using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("worlduiSceneWidgetProperties")]
    public class WorlduiSceneWidgetProperties : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("faceVector")]
        public Vector3 FaceVector { get; set; }
        
        [RealName("projectionPlaneSize")]
        public Vector2 ProjectionPlaneSize { get; set; }
        
        [RealName("maxInteractionDistance")]
        public float MaxInteractionDistance { get; set; }
        
        [RealName("renderingPlane")]
        public DumpedEnums.ERenderingPlane? RenderingPlane { get; set; }
        
        [RealName("useCustomFaceVector")]
        public bool UseCustomFaceVector { get; set; }
        
        [RealName("isInteractable")]
        public bool IsInteractable { get; set; }
        
        [RealName("isInteractableFromBehind")]
        public bool IsInteractableFromBehind { get; set; }
    }
}
