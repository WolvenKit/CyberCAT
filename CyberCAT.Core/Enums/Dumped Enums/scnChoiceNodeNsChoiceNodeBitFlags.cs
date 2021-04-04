using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum scnChoiceNodeNsChoiceNodeBitFlags
	{
		IsFocusClue = 1 << 0,
		IsValidInteractionFailsafeDisabled = 1 << 1
	}
}