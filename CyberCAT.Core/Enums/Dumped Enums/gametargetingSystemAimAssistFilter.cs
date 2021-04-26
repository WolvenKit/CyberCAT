using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum gametargetingSystemAimAssistFilter
	{
		Melee = 1 << 0,
		Shooting = 1 << 1,
		Scanning = 1 << 2,
		QuickHack = 1 << 3,
		ShootingLimbCyber = 1 << 4,
		HeadTarget = 1 << 5,
		LegTarget = 1 << 6,
		MechanicalTarget = 1 << 7
	}
}