using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum physicsRagdollBodyPartE
	{
		HEAD = 1 << 0,
		LARM_UPPER = 1 << 1,
		LARM_LOWER = 1 << 2,
		LARM_PALM = 1 << 3,
		RARM_UPPER = 1 << 4,
		RARM_LOWER = 1 << 5,
		RARM_PALM = 1 << 6,
		LLEG_UPPER = 1 << 7,
		LLEG_LOWER = 1 << 8,
		LLEG_FOOT = 1 << 9,
		RLEG_UPPER = 1 << 10,
		RLEG_LOWER = 1 << 11,
		RLEG_FOOT = 1 << 12,
		BODY = 1 << 13
	}
}