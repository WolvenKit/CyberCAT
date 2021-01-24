using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScriptableDeviceComponentPS")]
    public class ScriptableDeviceComponentPS : SharedGameplayPS
    {
        [RealName("isInitialized")]
        public bool IsInitialized { get; set; }
        
        [RealName("forceResolveStateOnAttach")]
        public bool ForceResolveStateOnAttach { get; set; }
        
        [RealName("forceVisibilityInAnimSystemOnLogicReady")]
        public bool ForceVisibilityInAnimSystemOnLogicReady { get; set; }
        
        [RealName("masters")]
        public Handle<GameDeviceComponentPS>[] Masters { get; set; }
        
        [RealName("mastersCached")]
        public bool MastersCached { get; set; }
        
        [RealName("deviceName")]
        public string DeviceName { get; set; }
        
        [RealName("activationState")]
        public DumpedEnums.EActivationState? ActivationState { get; set; }
        
        [RealName("drawGridLink")]
        public bool DrawGridLink { get; set; }
        
        [RealName("isLinkDynamic")]
        public bool IsLinkDynamic { get; set; }
        
        [RealName("fullDepth")]
        public bool FullDepth { get; set; }
        
        [RealName("virtualNetworkShapeID")]
        public TweakDbId VirtualNetworkShapeID { get; set; }
        
        [RealName("tweakDBRecord")]
        public TweakDbId TweakDBRecord { get; set; }
        
        [RealName("tweakDBDescriptionRecord")]
        public TweakDbId TweakDBDescriptionRecord { get; set; }
        
        [RealName("contentScale")]
        public TweakDbId ContentScale { get; set; }
        
        [RealName("skillCheckContainer")]
        public Handle<BaseSkillCheckContainer> SkillCheckContainer { get; set; }
        
        [RealName("hasUICameraZoom")]
        public bool HasUICameraZoom { get; set; }
        
        [RealName("allowUICameraZoomDynamicSwitch")]
        public bool AllowUICameraZoomDynamicSwitch { get; set; }
        
        [RealName("hasFullScreenUI")]
        public bool HasFullScreenUI { get; set; }
        
        [RealName("hasAuthorizationModule")]
        public bool HasAuthorizationModule { get; set; }
        
        [RealName("hasPersonalLinkSlot")]
        public bool HasPersonalLinkSlot { get; set; }
        
        [RealName("backdoorBreachDifficulty")]
        public DumpedEnums.EGameplayChallengeLevel? BackdoorBreachDifficulty { get; set; }
        
        [RealName("shouldSkipNetrunnerMinigame")]
        public bool ShouldSkipNetrunnerMinigame { get; set; }
        
        [RealName("minigameDefinition")]
        public TweakDbId MinigameDefinition { get; set; }
        
        [RealName("minigameAttempt")]
        public int MinigameAttempt { get; set; }
        
        [RealName("hackingMinigameState")]
        public DumpedEnums.gameuiHackingMinigameState? HackingMinigameState { get; set; }
        
        [RealName("disablePersonalLinkAutoDisconnect")]
        public bool DisablePersonalLinkAutoDisconnect { get; set; }
        
        [RealName("canHandleAdvancedInteraction")]
        public bool CanHandleAdvancedInteraction { get; set; }
        
        [RealName("canBeTrapped")]
        public bool CanBeTrapped { get; set; }
        
        [RealName("disassembleProperties")]
        public DisassembleOptions DisassembleProperties { get; set; }
        
        [RealName("flatheadScavengeProperties")]
        public SpiderbotScavengeOptions FlatheadScavengeProperties { get; set; }
        
        [RealName("destructionProperties")]
        public DestructionData DestructionProperties { get; set; }
        
        [RealName("canPlayerTakeOverControl")]
        public bool CanPlayerTakeOverControl { get; set; }
        
        [RealName("canBeInDeviceChain")]
        public bool CanBeInDeviceChain { get; set; }
        
        [RealName("personalLinkForced")]
        public bool PersonalLinkForced { get; set; }
        
        [RealName("personalLinkCustomInteraction")]
        public TweakDbId PersonalLinkCustomInteraction { get; set; }
        
        [RealName("personalLinkStatus")]
        public DumpedEnums.EPersonalLinkConnectionStatus? PersonalLinkStatus { get; set; }
        
        [RealName("isAdvancedInteractionModeOn")]
        public bool IsAdvancedInteractionModeOn { get; set; }
        
        [RealName("juryrigTrapState")]
        public DumpedEnums.EJuryrigTrapState? JuryrigTrapState { get; set; }
        
        [RealName("isControlledByThePlayer")]
        public bool IsControlledByThePlayer { get; set; }
        
        [RealName("isHighlightedInFocusMode")]
        public bool IsHighlightedInFocusMode { get; set; }
        
        [RealName("wasQuickHacked")]
        public bool WasQuickHacked { get; set; }
        
        [RealName("wasQuickHackAttempt")]
        public bool WasQuickHackAttempt { get; set; }
        
        [RealName("lastPerformedQuickHack")]
        public CName LastPerformedQuickHack { get; set; }
        
        [RealName("isGlitching")]
        public bool IsGlitching { get; set; }
        
        [RealName("isRestarting")]
        public bool IsRestarting { get; set; }
        
        [RealName("blockSecurityWakeUp")]
        public bool BlockSecurityWakeUp { get; set; }
        
        [RealName("isLockedViaSequencer")]
        public bool IsLockedViaSequencer { get; set; }
        
        [RealName("distractExecuted")]
        public bool DistractExecuted { get; set; }
        
        [RealName("distractionTimeCompleted")]
        public bool DistractionTimeCompleted { get; set; }
        
        [RealName("hasNPCWorkspotKillInteraction")]
        public bool HasNPCWorkspotKillInteraction { get; set; }
        
        [RealName("shouldNPCWorkspotFinishLoop")]
        public bool ShouldNPCWorkspotFinishLoop { get; set; }
        
        [RealName("durabilityState")]
        public DumpedEnums.EDeviceDurabilityState? DurabilityState { get; set; }
        
        [RealName("hasBeenScavenged")]
        public bool HasBeenScavenged { get; set; }
        
        [RealName("currentlyAuthorizedUsers")]
        public SecuritySystemClearanceEntry[] CurrentlyAuthorizedUsers { get; set; }
        
        [RealName("performedActions")]
        public SPerformedActions[] PerformedActions { get; set; }
        
        [RealName("isInitialStateOperationPerformed")]
        public bool IsInitialStateOperationPerformed { get; set; }
        
        [RealName("illegalActions")]
        public IllegalActionTypes IllegalActions { get; set; }
        
        [RealName("disableQuickHacks")]
        public bool DisableQuickHacks { get; set; }
        
        [RealName("availableQuickHacks")]
        public CName[] AvailableQuickHacks { get; set; }
        
        [RealName("isKeyloggerInstalled")]
        public bool IsKeyloggerInstalled { get; set; }
        
        [RealName("actionsWithDisabledRPGChecks")]
        public TweakDbId[] ActionsWithDisabledRPGChecks { get; set; }
        
        [RealName("availableSpiderbotActions")]
        public CName[] AvailableSpiderbotActions { get; set; }
        
        [RealName("currentSpiderbotActionPerformed")]
        public Handle<ScriptableDeviceAction> CurrentSpiderbotActionPerformed { get; set; }
        
        [RealName("isSpiderbotInteractionOrdered")]
        public bool IsSpiderbotInteractionOrdered { get; set; }
        
        [RealName("shouldScannerShowStatus")]
        public bool ShouldScannerShowStatus { get; set; }
        
        [RealName("shouldScannerShowNetwork")]
        public bool ShouldScannerShowNetwork { get; set; }
        
        [RealName("shouldScannerShowAttitude")]
        public bool ShouldScannerShowAttitude { get; set; }
        
        [RealName("shouldScannerShowRole")]
        public bool ShouldScannerShowRole { get; set; }
        
        [RealName("shouldScannerShowHealth")]
        public bool ShouldScannerShowHealth { get; set; }
        
        [RealName("debugDevice")]
        public bool DebugDevice { get; set; }
        
        [RealName("debugName")]
        public CName DebugName { get; set; }
        
        [RealName("debugExposeQuickHacks")]
        public bool DebugExposeQuickHacks { get; set; }
        
        [RealName("debugPath")]
        public CName DebugPath { get; set; }
        
        [RealName("debugID")]
        public uint DebugID { get; set; }
        
        [RealName("deviceOperationsSetup")]
        public Handle<DeviceOperationsContainer> DeviceOperationsSetup { get; set; }
        
        [RealName("connectionHighlightObjects")]
        public NodeRef[] ConnectionHighlightObjects { get; set; }
        
        [RealName("activeContexts")]
        public DumpedEnums.gamedeviceRequestType?[] ActiveContexts { get; set; }
        
        [RealName("playstyles")]
        public DumpedEnums.EPlaystyle?[] Playstyles { get; set; }
        
        [RealName("quickHackVulnerabilties")]
        public TweakDbId[] QuickHackVulnerabilties { get; set; }
        
        [RealName("quickHackVulnerabiltiesInitialized")]
        public bool QuickHackVulnerabiltiesInitialized { get; set; }
        
        [RealName("willingInvestigators")]
        public EntEntityID[] WillingInvestigators { get; set; }
        
        [RealName("isInteractive")]
        public bool IsInteractive { get; set; }
    }
}
