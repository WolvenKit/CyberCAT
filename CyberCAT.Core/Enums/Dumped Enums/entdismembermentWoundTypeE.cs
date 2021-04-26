using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum entdismembermentWoundTypeE
	{
		CLEAN = 1 << 0,
		COARSE = 1 << 1,
		HOLE = 1 << 6
	}
}