using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum entdismembermentPlacementE
	{
		MAIN_MESH = 1 << 4,
		DISM_MESH = 1 << 5,
		RAGDOLL_CONTACT = 1 << 8,
		RAGDOLL_CONTACT_SLIDE = 1 << 9,
		RAGDOLL_SLEEP = 1 << 10
	}
}