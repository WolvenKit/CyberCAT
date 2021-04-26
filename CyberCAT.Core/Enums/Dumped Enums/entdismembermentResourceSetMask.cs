using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum entdismembermentResourceSetMask
	{
		BARE = 1 << 0,
		BARE1 = 1 << 1,
		BARE2 = 1 << 2,
		BARE3 = 1 << 3,
		GARMENT = 1 << 4,
		GARMENT1 = 1 << 5,
		GARMENT2 = 1 << 6,
		GARMENT3 = 1 << 7,
		CYBER = 1 << 8,
		CYBER1 = 1 << 9,
		CYBER2 = 1 << 10,
		CYBER3 = 1 << 11,
		MIXED = 1 << 12,
		MIXED1 = 1 << 13,
		MIXED2 = 1 << 14,
		MIXED3 = 1 << 15
	}
}