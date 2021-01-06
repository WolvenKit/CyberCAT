using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("ScriptableDeviceComponentPS")]
    public class ScriptableDeviceComponentPS : SharedGameplayPS
    {
        [RealName("isInitialized")]
        [RealType("Bool")]
        public bool IsInitialized { get; set; }
        
        [RealName("forceResolveStateOnAttach")]
        [RealType("Bool")]
        public bool ForceResolveStateOnAttach { get; set; }
        
        [RealName("forceVisibilityInAnimSystemOnLogicReady")]
        [RealType("Bool")]
        public bool ForceVisibilityInAnimSystemOnLogicReady { get; set; }
        
        [RealName("masters")]
        public Handle<GameDeviceComponentPS>[] Masters { get; set; }
        
        [RealName("mastersCached")]
        [RealType("Bool")]
        public bool MastersCached { get; set; }
        
        [RealName("deviceName")]
        [RealType("String")]
        public string DeviceName { get; set; }
        
        [RealName("activationState")]
        public DumpedEnums.EActivationState? ActivationState { get; set; }
        
        [RealName("drawGridLink")]
        [RealType("Bool")]
        public bool DrawGridLink { get; set; }
        
        [RealName("isLinkDynamic")]
        [RealType("Bool")]
        public bool IsLinkDynamic { get; set; }
        
        [RealName("fullDepth")]
        [RealType("Bool")]
        public bool FullDepth { get; set; }
        
        [RealName("virtualNetworkShapeID")]
        [RealType("TweakDBID")]
        public TweakDbId VirtualNetworkShapeID { get; set; }
        
        [RealName("tweakDBRecord")]
        [RealType("TweakDBID")]
        public TweakDbId TweakDBRecord { get; set; }
        
        [RealName("tweakDBDescriptionRecord")]
        [RealType("TweakDBID")]
        public TweakDbId TweakDBDescriptionRecord { get; set; }
        
        [RealName("contentScale")]
        [RealType("TweakDBID")]
        public TweakDbId ContentScale { get; set; }
        
        [RealName("skillCheckContainer")]
        public Handle<BaseSkillCheckContainer> SkillCheckContainer { get; set; }
        
        [RealName("hasUICameraZoom")]
        [RealType("Bool")]
        public bool HasUICameraZoom { get; set; }
        
        [RealName("allowUICameraZoomDynamicSwitch")]
        [RealType("Bool")]
        public bool AllowUICameraZoomDynamicSwitch { get; set; }
        
        [RealName("hasFullScreenUI")]
        [RealType("Bool")]
        public bool HasFullScreenUI { get; set; }
        
        [RealName("hasAuthorizationModule")]
        [RealType("Bool")]
        public bool HasAuthorizationModule { get; set; }
        
        [RealName("hasPersonalLinkSlot")]
        [RealType("Bool")]
        public bool HasPersonalLinkSlot { get; set; }
        
        [RealName("backdoorBreachDifficulty")]
        public DumpedEnums.EGameplayChallengeLevel? BackdoorBreachDifficulty { get; set; }
        
        [RealName("shouldSkipNetrunnerMinigame")]
        [RealType("Bool")]
        public bool ShouldSkipNetrunnerMinigame { get; set; }
        
        [RealName("minigameDefinition")]
        [RealType("TweakDBID")]
        public TweakDbId MinigameDefinition { get; set; }
        
        [RealName("minigameAttempt")]
        [RealType("Int32")]
        public int MinigameAttempt { get; set; }
        
        [RealName("hackingMinigameState")]
        public DumpedEnums.gameuiHackingMinigameState? HackingMinigameState { get; set; }
        
        [RealName("disablePersonalLinkAutoDisconnect")]
        [RealType("Bool")]
        public bool DisablePersonalLinkAutoDisconnect { get; set; }
        
        [RealName("canHandleAdvancedInteraction")]
        [RealType("Bool")]
        public bool CanHandleAdvancedInteraction { get; set; }
        
        [RealName("canBeTrapped")]
        [RealType("Bool")]
        public bool CanBeTrapped { get; set; }
        
        [RealName("disassembleProperties")]
        public DisassembleOptions DisassembleProperties { get; set; }
        
        [RealName("flatheadScavengeProperties")]
        public SpiderbotScavengeOptions FlatheadScavengeProperties { get; set; }
        
        [RealName("destructionProperties")]
        public DestructionData DestructionProperties { get; set; }
        
        [RealName("canPlayerTakeOverControl")]
        [RealType("Bool")]
        public bool CanPlayerTakeOverControl { get; set; }
        
        [RealName("canBeInDeviceChain")]
        [RealType("Bool")]
        public bool CanBeInDeviceChain { get; set; }
        
        [RealName("personalLinkForced")]
        [RealType("Bool")]
        public bool PersonalLinkForced { get; set; }
        
        [RealName("personalLinkCustomInteraction")]
        [RealType("TweakDBID")]
        public TweakDbId PersonalLinkCustomInteraction { get; set; }
        
        [RealName("personalLinkStatus")]
        public DumpedEnums.EPersonalLinkConnectionStatus? PersonalLinkStatus { get; set; }
        
        [RealName("isAdvancedInteractionModeOn")]
        [RealType("Bool")]
        public bool IsAdvancedInteractionModeOn { get; set; }
        
        [RealName("juryrigTrapState")]
        public DumpedEnums.EJuryrigTrapState? JuryrigTrapState { get; set; }
        
        [RealName("isControlledByThePlayer")]
        [RealType("Bool")]
        public bool IsControlledByThePlayer { get; set; }
        
        [RealName("isHighlightedInFocusMode")]
        [RealType("Bool")]
        public bool IsHighlightedInFocusMode { get; set; }
        
        [RealName("wasQuickHacked")]
        [RealType("Bool")]
        public bool WasQuickHacked { get; set; }
        
        [RealName("wasQuickHackAttempt")]
        [RealType("Bool")]
        public bool WasQuickHackAttempt { get; set; }
        
        [RealName("lastPerformedQuickHack")]
        [RealType("CName")]
        public string LastPerformedQuickHack { get; set; }
        
        [RealName("isGlitching")]
        [RealType("Bool")]
        public bool IsGlitching { get; set; }
        
        [RealName("isRestarting")]
        [RealType("Bool")]
        public bool IsRestarting { get; set; }
        
        [RealName("blockSecurityWakeUp")]
        [RealType("Bool")]
        public bool BlockSecurityWakeUp { get; set; }
        
        [RealName("isLockedViaSequencer")]
        [RealType("Bool")]
        public bool IsLockedViaSequencer { get; set; }
        
        [RealName("distractExecuted")]
        [RealType("Bool")]
        public bool DistractExecuted { get; set; }
        
        [RealName("distractionTimeCompleted")]
        [RealType("Bool")]
        public bool DistractionTimeCompleted { get; set; }
        
        [RealName("hasNPCWorkspotKillInteraction")]
        [RealType("Bool")]
        public bool HasNPCWorkspotKillInteraction { get; set; }
        
        [RealName("shouldNPCWorkspotFinishLoop")]
        [RealType("Bool")]
        public bool ShouldNPCWorkspotFinishLoop { get; set; }
        
        [RealName("durabilityState")]
        public DumpedEnums.EDeviceDurabilityState? DurabilityState { get; set; }
        
        [RealName("hasBeenScavenged")]
        [RealType("Bool")]
        public bool HasBeenScavenged { get; set; }
        
        [RealName("currentlyAuthorizedUsers")]
        public SecuritySystemClearanceEntry[] CurrentlyAuthorizedUsers { get; set; }
        
        [RealName("performedActions")]
        public SPerformedActions[] PerformedActions { get; set; }
        
        [RealName("isInitialStateOperationPerformed")]
        [RealType("Bool")]
        public bool IsInitialStateOperationPerformed { get; set; }
        
        [RealName("illegalActions")]
        public IllegalActionTypes IllegalActions { get; set; }
        
        [RealName("disableQuickHacks")]
        [RealType("Bool")]
        public bool DisableQuickHacks { get; set; }
        
        [RealName("availableQuickHacks")]
        [RealType("CName")]
        public string[] AvailableQuickHacks { get; set; }
        
        [RealName("isKeyloggerInstalled")]
        [RealType("Bool")]
        public bool IsKeyloggerInstalled { get; set; }
        
        [RealName("actionsWithDisabledRPGChecks")]
        [RealType("TweakDBID")]
        public TweakDbId[] ActionsWithDisabledRPGChecks { get; set; }
        
        [RealName("availableSpiderbotActions")]
        [RealType("CName")]
        public string[] AvailableSpiderbotActions { get; set; }
        
        [RealName("currentSpiderbotActionPerformed")]
        public Handle<ScriptableDeviceAction> CurrentSpiderbotActionPerformed { get; set; }
        
        [RealName("isSpiderbotInteractionOrdered")]
        [RealType("Bool")]
        public bool IsSpiderbotInteractionOrdered { get; set; }
        
        [RealName("shouldScannerShowStatus")]
        [RealType("Bool")]
        public bool ShouldScannerShowStatus { get; set; }
        
        [RealName("shouldScannerShowNetwork")]
        [RealType("Bool")]
        public bool ShouldScannerShowNetwork { get; set; }
        
        [RealName("shouldScannerShowAttitude")]
        [RealType("Bool")]
        public bool ShouldScannerShowAttitude { get; set; }
        
        [RealName("shouldScannerShowRole")]
        [RealType("Bool")]
        public bool ShouldScannerShowRole { get; set; }
        
        [RealName("shouldScannerShowHealth")]
        [RealType("Bool")]
        public bool ShouldScannerShowHealth { get; set; }
        
        [RealName("debugDevice")]
        [RealType("Bool")]
        public bool DebugDevice { get; set; }
        
        [RealName("debugName")]
        [RealType("CName")]
        public string DebugName { get; set; }
        
        [RealName("debugExposeQuickHacks")]
        [RealType("Bool")]
        public bool DebugExposeQuickHacks { get; set; }
        
        [RealName("debugPath")]
        [RealType("CName")]
        public string DebugPath { get; set; }
        
        [RealName("debugID")]
        [RealType("Uint32")]
        public uint DebugID { get; set; }
        
        [RealName("deviceOperationsSetup")]
        public Handle<DeviceOperationsContainer> DeviceOperationsSetup { get; set; }
        
        [RealName("connectionHighlightObjects")]
        [RealType("NodeRef")]
        public string[] ConnectionHighlightObjects { get; set; }
        
        [RealName("activeContexts")]
        public DumpedEnums.gamedeviceRequestType?[] ActiveContexts { get; set; }
        
        [RealName("playstyles")]
        public DumpedEnums.EPlaystyle?[] Playstyles { get; set; }
        
        [RealName("quickHackVulnerabilties")]
        [RealType("TweakDBID")]
        public TweakDbId[] QuickHackVulnerabilties { get; set; }
        
        [RealName("quickHackVulnerabiltiesInitialized")]
        [RealType("Bool")]
        public bool QuickHackVulnerabiltiesInitialized { get; set; }
        
        [RealName("willingInvestigators")]
        public EntEntityID[] WillingInvestigators { get; set; }
        
        [RealName("isInteractive")]
        [RealType("Bool")]
        public bool IsInteractive { get; set; }
    }
}
