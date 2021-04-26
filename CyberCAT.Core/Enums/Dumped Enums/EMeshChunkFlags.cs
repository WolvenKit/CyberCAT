using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum EMeshChunkFlags
	{
		MCF_RenderInScene = 1 << 0,
		MCF_RenderInShadows = 1 << 1,
		MCF_IsTwoSided = 1 << 2,
		MCF_IsRayTracedEmissive = 1 << 3,
		MCF_IsPrefabProxy = 1 << 6
	}
}