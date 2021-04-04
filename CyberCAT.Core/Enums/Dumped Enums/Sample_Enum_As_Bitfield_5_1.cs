using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum Sample_Enum_As_Bitfield_5_1
	{
		Sample_Bitfield_Option_5_1_0 = 1 << 0,
		Sample_Bitfield_Option_5_1_1 = 1 << 1,
		MyCustomBitfieldOptionName512 = 1 << 2
	}
}