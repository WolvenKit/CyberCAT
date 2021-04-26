namespace CyberCAT.Core.DumpedEnums
{
	public enum gsmStateError
	{
		StateError_OK = 0,
		StateError_SettingsCorrupted = 1,
		StateError_SettingsCorrupted_Save = 2,
		StateError_ProfileCorrupted = 3,
		StateError_ProfileCorrupted_Save = 4,
		StateError_CannotInitializeContext = 5,
		StateError_CantInitializeSession = 6,
		StateError_CantLoadSave_CantLoadFile = 7,
		StateError_CantLoadSave_CantCreateLoadStream = 8,
		StateError_CantLoadSave_CensorshipLevelMismatch = 9,
		StateError_CantLoadSave_CensorshipOptionalNudity = 10,
		StateError_CantLoadSave_VersionMismatch = 11,
		StateError_CantLoadSave_Corrupted = 12,
		StateError_CantLoadSave_SessionDescInvalid = 13
	}
}
