using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum CensorshipFlags
	{
		Censor_Nudity = 1 << 0,
		Censor_OverSexualised = 1 << 1,
		Censor_Suggestive = 1 << 2,
		Censor_Homosexuality = 1 << 3,
		Censor_Gore = 1 << 4,
		Censor_Drugs = 1 << 5,
		Censor_Religion = 1 << 6,
		Censor_Chinese = 1 << 7
	}
}