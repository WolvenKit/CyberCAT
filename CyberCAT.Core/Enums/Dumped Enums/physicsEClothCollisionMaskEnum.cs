using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum physicsEClothCollisionMaskEnum
	{
		SPHERE = 1 << 0,
		BOX = 1 << 1,
		CONVEX = 1 << 2,
		TRIMESH = 1 << 3,
		CAPSULE = 1 << 4
	}
}