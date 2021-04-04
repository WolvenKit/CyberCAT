using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum EMeshChunkRenderMask
	{
		MCR_Scene = 1 << 0,
		MCR_Cascade1 = 1 << 1,
		MCR_Cascade2 = 1 << 2,
		MCR_Cascade3 = 1 << 3,
		MCR_Cascade4 = 1 << 4,
		MCR_LocalShadows = 1 << 5,
		MCR_IsTwoSided = 1 << 6,
		MCR_DistantShadows = 1 << 7,
		MCR_IsRayTracedEmissive = 1 << 8,
		MCR_PrefabProxy = 1 << 11,
		MCR_Cascades = 1 << 12
	}
}