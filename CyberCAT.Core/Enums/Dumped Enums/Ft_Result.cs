namespace CyberCAT.Core.DumpedEnums
{
public enum Ft_Result
{
	Success = 0,
	GettingPlayerGameObjectFailed = 1,
	GetPSMBlackboardFailed = 2,
	GetStatsPoolFailed = 3,
	NoEnemyFoundInSpawner = 4,
	NoEnemyFoundInPool = 5,
	NoEntitiesFoundInSpawner = 6,
	NoEnemyTargeted = 7,
	FailedToSelectGrapple = 8,
	FailedToSelectTakedown = 9,
	TakedownWithoutGrappleAttempt = 10,
	NoInteractionAvailable = 11,
	RequestedInteractionNotAvailable = 12,
	OutOfRange = 13,
	TargetNotInEnemyPool = 14,
	DescriptorFormatError = 15
}
}
