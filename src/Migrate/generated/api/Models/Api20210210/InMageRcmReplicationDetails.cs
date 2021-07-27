namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm provider specific details.</summary>
    public partial class InMageRcmReplicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings __replicationProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReplicationProviderSpecificSettings();

        /// <summary>Backing field for <see cref="AgentUpgradeAttemptToVersion" /> property.</summary>
        private string _agentUpgradeAttemptToVersion;

        /// <summary>The agent version to which last agent upgrade was attempted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AgentUpgradeAttemptToVersion { get => this._agentUpgradeAttemptToVersion; }

        /// <summary>Backing field for <see cref="AgentUpgradeBlockingErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetails[] _agentUpgradeBlockingErrorDetail;

        /// <summary>The agent upgrade blocking error information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetails[] AgentUpgradeBlockingErrorDetail { get => this._agentUpgradeBlockingErrorDetail; set => this._agentUpgradeBlockingErrorDetail = value; }

        /// <summary>Backing field for <see cref="AgentUpgradeJobId" /> property.</summary>
        private string _agentUpgradeJobId;

        /// <summary>The agent upgrade job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AgentUpgradeJobId { get => this._agentUpgradeJobId; }

        /// <summary>Backing field for <see cref="AgentUpgradeState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MobilityAgentUpgradeState? _agentUpgradeState;

        /// <summary>The agent auto upgrade state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MobilityAgentUpgradeState? AgentUpgradeState { get => this._agentUpgradeState; }

        /// <summary>Backing field for <see cref="AllocatedMemoryInMb" /> property.</summary>
        private double? _allocatedMemoryInMb;

        /// <summary>The allocated memory in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? AllocatedMemoryInMb { get => this._allocatedMemoryInMb; }

        /// <summary>Backing field for <see cref="DiscoveryType" /> property.</summary>
        private string _discoveryType;

        /// <summary>The type of the discovered VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiscoveryType { get => this._discoveryType; }

        /// <summary>Backing field for <see cref="FabricDiscoveryMachineId" /> property.</summary>
        private string _fabricDiscoveryMachineId;

        /// <summary>The ARM Id of the discovered VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricDiscoveryMachineId { get => this._fabricDiscoveryMachineId; }

        /// <summary>Backing field for <see cref="FailoverRecoveryPointId" /> property.</summary>
        private string _failoverRecoveryPointId;

        /// <summary>The recovery point Id to which the VM was failed over.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FailoverRecoveryPointId { get => this._failoverRecoveryPointId; }

        /// <summary>Backing field for <see cref="FirmwareType" /> property.</summary>
        private string _firmwareType;

        /// <summary>The firmware type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FirmwareType { get => this._firmwareType; }

        /// <summary>Backing field for <see cref="InitialReplicationProcessedByte" /> property.</summary>
        private long? _initialReplicationProcessedByte;

        /// <summary>
        /// The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected
        /// disks in source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? InitialReplicationProcessedByte { get => this._initialReplicationProcessedByte; }

        /// <summary>Backing field for <see cref="InitialReplicationProgressHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? _initialReplicationProgressHealth;

        /// <summary>The initial replication progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? InitialReplicationProgressHealth { get => this._initialReplicationProgressHealth; }

        /// <summary>Backing field for <see cref="InitialReplicationProgressPercentage" /> property.</summary>
        private int? _initialReplicationProgressPercentage;

        /// <summary>
        /// The initial replication progress percentage. This is calculated based on total bytes processed for all disks in the source
        /// VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? InitialReplicationProgressPercentage { get => this._initialReplicationProgressPercentage; }

        /// <summary>Backing field for <see cref="InitialReplicationTransferredByte" /> property.</summary>
        private long? _initialReplicationTransferredByte;

        /// <summary>
        /// The initial replication transferred bytes from source VM to azure for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? InitialReplicationTransferredByte { get => this._initialReplicationTransferredByte; }

        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType; }

        /// <summary>Backing field for <see cref="InternalIdentifier" /> property.</summary>
        private string _internalIdentifier;

        /// <summary>The virtual machine internal identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InternalIdentifier { get => this._internalIdentifier; }

        /// <summary>Backing field for <see cref="IsLastUpgradeSuccessful" /> property.</summary>
        private string _isLastUpgradeSuccessful;

        /// <summary>A value indicating whether last agent upgrade was successful or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsLastUpgradeSuccessful { get => this._isLastUpgradeSuccessful; }

        /// <summary>Backing field for <see cref="LastAgentUpgradeErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetails[] _lastAgentUpgradeErrorDetail;

        /// <summary>The last agent upgrade error information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetails[] LastAgentUpgradeErrorDetail { get => this._lastAgentUpgradeErrorDetail; set => this._lastAgentUpgradeErrorDetail = value; }

        /// <summary>Backing field for <see cref="LastAgentUpgradeType" /> property.</summary>
        private string _lastAgentUpgradeType;

        /// <summary>The last agent upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LastAgentUpgradeType { get => this._lastAgentUpgradeType; }

        /// <summary>Backing field for <see cref="LastRecoveryPointId" /> property.</summary>
        private string _lastRecoveryPointId;

        /// <summary>The last recovery point Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LastRecoveryPointId { get => this._lastRecoveryPointId; }

        /// <summary>Backing field for <see cref="LastRecoveryPointReceived" /> property.</summary>
        private global::System.DateTime? _lastRecoveryPointReceived;

        /// <summary>The last recovery point received time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastRecoveryPointReceived { get => this._lastRecoveryPointReceived; }

        /// <summary>Backing field for <see cref="LastRpoCalculatedTime" /> property.</summary>
        private global::System.DateTime? _lastRpoCalculatedTime;

        /// <summary>The last recovery point objective calculated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastRpoCalculatedTime { get => this._lastRpoCalculatedTime; }

        /// <summary>Backing field for <see cref="LastRpoInSecond" /> property.</summary>
        private long? _lastRpoInSecond;

        /// <summary>The last recovery point objective value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? LastRpoInSecond { get => this._lastRpoInSecond; }

        /// <summary>Backing field for <see cref="LicenseType" /> property.</summary>
        private string _licenseType;

        /// <summary>License Type of the VM to be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LicenseType { get => this._licenseType; set => this._licenseType = value; }

        /// <summary>Internal Acessors for AgentUpgradeAttemptToVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.AgentUpgradeAttemptToVersion { get => this._agentUpgradeAttemptToVersion; set { {_agentUpgradeAttemptToVersion = value;} } }

        /// <summary>Internal Acessors for AgentUpgradeJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.AgentUpgradeJobId { get => this._agentUpgradeJobId; set { {_agentUpgradeJobId = value;} } }

        /// <summary>Internal Acessors for AgentUpgradeState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MobilityAgentUpgradeState? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.AgentUpgradeState { get => this._agentUpgradeState; set { {_agentUpgradeState = value;} } }

        /// <summary>Internal Acessors for AllocatedMemoryInMb</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.AllocatedMemoryInMb { get => this._allocatedMemoryInMb; set { {_allocatedMemoryInMb = value;} } }

        /// <summary>Internal Acessors for DiscoveryType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.DiscoveryType { get => this._discoveryType; set { {_discoveryType = value;} } }

        /// <summary>Internal Acessors for FabricDiscoveryMachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.FabricDiscoveryMachineId { get => this._fabricDiscoveryMachineId; set { {_fabricDiscoveryMachineId = value;} } }

        /// <summary>Internal Acessors for FailoverRecoveryPointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.FailoverRecoveryPointId { get => this._failoverRecoveryPointId; set { {_failoverRecoveryPointId = value;} } }

        /// <summary>Internal Acessors for FirmwareType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.FirmwareType { get => this._firmwareType; set { {_firmwareType = value;} } }

        /// <summary>Internal Acessors for InitialReplicationProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.InitialReplicationProcessedByte { get => this._initialReplicationProcessedByte; set { {_initialReplicationProcessedByte = value;} } }

        /// <summary>Internal Acessors for InitialReplicationProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.InitialReplicationProgressHealth { get => this._initialReplicationProgressHealth; set { {_initialReplicationProgressHealth = value;} } }

        /// <summary>Internal Acessors for InitialReplicationProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.InitialReplicationProgressPercentage { get => this._initialReplicationProgressPercentage; set { {_initialReplicationProgressPercentage = value;} } }

        /// <summary>Internal Acessors for InitialReplicationTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.InitialReplicationTransferredByte { get => this._initialReplicationTransferredByte; set { {_initialReplicationTransferredByte = value;} } }

        /// <summary>Internal Acessors for InternalIdentifier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.InternalIdentifier { get => this._internalIdentifier; set { {_internalIdentifier = value;} } }

        /// <summary>Internal Acessors for IsLastUpgradeSuccessful</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.IsLastUpgradeSuccessful { get => this._isLastUpgradeSuccessful; set { {_isLastUpgradeSuccessful = value;} } }

        /// <summary>Internal Acessors for LastAgentUpgradeType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.LastAgentUpgradeType { get => this._lastAgentUpgradeType; set { {_lastAgentUpgradeType = value;} } }

        /// <summary>Internal Acessors for LastRecoveryPointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.LastRecoveryPointId { get => this._lastRecoveryPointId; set { {_lastRecoveryPointId = value;} } }

        /// <summary>Internal Acessors for LastRecoveryPointReceived</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.LastRecoveryPointReceived { get => this._lastRecoveryPointReceived; set { {_lastRecoveryPointReceived = value;} } }

        /// <summary>Internal Acessors for LastRpoCalculatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.LastRpoCalculatedTime { get => this._lastRpoCalculatedTime; set { {_lastRpoCalculatedTime = value;} } }

        /// <summary>Internal Acessors for LastRpoInSecond</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.LastRpoInSecond { get => this._lastRpoInSecond; set { {_lastRpoInSecond = value;} } }

        /// <summary>Internal Acessors for MobilityAgentDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetail { get => (this._mobilityAgentDetail = this._mobilityAgentDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmMobilityAgentDetails()); set { {_mobilityAgentDetail = value;} } }

        /// <summary>Internal Acessors for MobilityAgentDetailAgentVersionExpiryDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailAgentVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).AgentVersionExpiryDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).AgentVersionExpiryDate = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailDriverVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailDriverVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersion = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailDriverVersionExpiryDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailDriverVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersionExpiryDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersionExpiryDate = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailIsUpgradeable</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailIsUpgradeable { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).IsUpgradeable; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).IsUpgradeable = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailLastHeartbeatUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailLastHeartbeatUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LastHeartbeatUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LastHeartbeatUtc = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailLatestAgentReleaseDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailLatestAgentReleaseDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestAgentReleaseDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestAgentReleaseDate = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailLatestUpgradableVersionWithoutReboot</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestUpgradableVersionWithoutReboot; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestUpgradableVersionWithoutReboot = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailLatestVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailLatestVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestVersion = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailReasonsBlockingUpgrade</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailReasonsBlockingUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).ReasonsBlockingUpgrade; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).ReasonsBlockingUpgrade = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MobilityAgentDetailVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).Version = value; }

        /// <summary>Internal Acessors for MultiVMGroupName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.MultiVMGroupName { get => this._multiVMGroupName; set { {_multiVMGroupName = value;} } }

        /// <summary>Internal Acessors for OSType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.OSType { get => this._oSType; set { {_oSType = value;} } }

        /// <summary>Internal Acessors for PrimaryNicIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.PrimaryNicIPAddress { get => this._primaryNicIPAddress; set { {_primaryNicIPAddress = value;} } }

        /// <summary>Internal Acessors for ProcessServerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ProcessServerId { get => this._processServerId; set { {_processServerId = value;} } }

        /// <summary>Internal Acessors for ProcessServerName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ProcessServerName { get => this._processServerName; set { {_processServerName = value;} } }

        /// <summary>Internal Acessors for ProcessorCoreCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ProcessorCoreCount { get => this._processorCoreCount; set { {_processorCoreCount = value;} } }

        /// <summary>Internal Acessors for ResyncProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ResyncProcessedByte { get => this._resyncProcessedByte; set { {_resyncProcessedByte = value;} } }

        /// <summary>Internal Acessors for ResyncProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ResyncProgressHealth { get => this._resyncProgressHealth; set { {_resyncProgressHealth = value;} } }

        /// <summary>Internal Acessors for ResyncProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ResyncProgressPercentage { get => this._resyncProgressPercentage; set { {_resyncProgressPercentage = value;} } }

        /// <summary>Internal Acessors for ResyncRequired</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ResyncRequired { get => this._resyncRequired; set { {_resyncRequired = value;} } }

        /// <summary>Internal Acessors for ResyncState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ResyncState { get => this._resyncState; set { {_resyncState = value;} } }

        /// <summary>Internal Acessors for ResyncTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.ResyncTransferredByte { get => this._resyncTransferredByte; set { {_resyncTransferredByte = value;} } }

        /// <summary>Internal Acessors for RunAsAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.RunAsAccountId { get => this._runAsAccountId; set { {_runAsAccountId = value;} } }

        /// <summary>Internal Acessors for TargetGeneration</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReplicationDetailsInternal.TargetGeneration { get => this._targetGeneration; set { {_targetGeneration = value;} } }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType = value; }

        /// <summary>Backing field for <see cref="MobilityAgentDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetails _mobilityAgentDetail;

        /// <summary>The mobility agent information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetails MobilityAgentDetail { get => (this._mobilityAgentDetail = this._mobilityAgentDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmMobilityAgentDetails()); set => this._mobilityAgentDetail = value; }

        /// <summary>The agent version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? MobilityAgentDetailAgentVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).AgentVersionExpiryDate; }

        /// <summary>The driver version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailDriverVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersion; }

        /// <summary>The driver version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? MobilityAgentDetailDriverVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersionExpiryDate; }

        /// <summary>A value indicating whether agent is upgradeable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailIsUpgradeable { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).IsUpgradeable; }

        /// <summary>The time of the last heartbeat received from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? MobilityAgentDetailLastHeartbeatUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LastHeartbeatUtc; }

        /// <summary>The latest agent version release date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailLatestAgentReleaseDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestAgentReleaseDate; }

        /// <summary>The latest upgradeable version available without reboot.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestUpgradableVersionWithoutReboot; }

        /// <summary>The latest agent version available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailLatestVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).LatestVersion; }

        /// <summary>The whether update is possible or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] MobilityAgentDetailReasonsBlockingUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).ReasonsBlockingUpgrade; }

        /// <summary>The agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetailsInternal)MobilityAgentDetail).Version; }

        /// <summary>Backing field for <see cref="MultiVMGroupName" /> property.</summary>
        private string _multiVMGroupName;

        /// <summary>The multi VM group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupName { get => this._multiVMGroupName; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The type of the OS on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; }

        /// <summary>Backing field for <see cref="PrimaryNicIPAddress" /> property.</summary>
        private string _primaryNicIPAddress;

        /// <summary>The IP address of the primary network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PrimaryNicIPAddress { get => this._primaryNicIPAddress; }

        /// <summary>Backing field for <see cref="ProcessServerId" /> property.</summary>
        private string _processServerId;

        /// <summary>The process server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProcessServerId { get => this._processServerId; }

        /// <summary>Backing field for <see cref="ProcessServerName" /> property.</summary>
        private string _processServerName;

        /// <summary>The process server name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProcessServerName { get => this._processServerName; }

        /// <summary>Backing field for <see cref="ProcessorCoreCount" /> property.</summary>
        private int? _processorCoreCount;

        /// <summary>The processor core count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ProcessorCoreCount { get => this._processorCoreCount; }

        /// <summary>Backing field for <see cref="ProtectedDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetails[] _protectedDisk;

        /// <summary>The list of protected disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetails[] ProtectedDisk { get => this._protectedDisk; set => this._protectedDisk = value; }

        /// <summary>Backing field for <see cref="ResyncProcessedByte" /> property.</summary>
        private long? _resyncProcessedByte;

        /// <summary>
        /// The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source
        /// VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncProcessedByte { get => this._resyncProcessedByte; }

        /// <summary>Backing field for <see cref="ResyncProgressHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? _resyncProgressHealth;

        /// <summary>The resync progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? ResyncProgressHealth { get => this._resyncProgressHealth; }

        /// <summary>Backing field for <see cref="ResyncProgressPercentage" /> property.</summary>
        private int? _resyncProgressPercentage;

        /// <summary>
        /// The resync progress percentage. This is calculated based on total bytes processed for all disks in the source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ResyncProgressPercentage { get => this._resyncProgressPercentage; }

        /// <summary>Backing field for <see cref="ResyncRequired" /> property.</summary>
        private string _resyncRequired;

        /// <summary>A value indicating whether resync is required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResyncRequired { get => this._resyncRequired; }

        /// <summary>Backing field for <see cref="ResyncState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? _resyncState;

        /// <summary>The resync state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get => this._resyncState; }

        /// <summary>Backing field for <see cref="ResyncTransferredByte" /> property.</summary>
        private long? _resyncTransferredByte;

        /// <summary>
        /// The resync transferred bytes from source VM to azure for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncTransferredByte { get => this._resyncTransferredByte; }

        /// <summary>Backing field for <see cref="RunAsAccountId" /> property.</summary>
        private string _runAsAccountId;

        /// <summary>The run-as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RunAsAccountId { get => this._runAsAccountId; }

        /// <summary>Backing field for <see cref="TargetAvailabilitySetId" /> property.</summary>
        private string _targetAvailabilitySetId;

        /// <summary>The target availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilitySetId { get => this._targetAvailabilitySetId; set => this._targetAvailabilitySetId = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilityZone" /> property.</summary>
        private string _targetAvailabilityZone;

        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilityZone { get => this._targetAvailabilityZone; set => this._targetAvailabilityZone = value; }

        /// <summary>
        /// Backing field for <see cref="TargetBootDiagnosticsStorageAccountId" /> property.
        /// </summary>
        private string _targetBootDiagnosticsStorageAccountId;

        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetBootDiagnosticsStorageAccountId { get => this._targetBootDiagnosticsStorageAccountId; set => this._targetBootDiagnosticsStorageAccountId = value; }

        /// <summary>Backing field for <see cref="TargetGeneration" /> property.</summary>
        private string _targetGeneration;

        /// <summary>The target generation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetGeneration { get => this._targetGeneration; }

        /// <summary>Backing field for <see cref="TargetLocation" /> property.</summary>
        private string _targetLocation;

        /// <summary>The target location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetLocation { get => this._targetLocation; set => this._targetLocation = value; }

        /// <summary>Backing field for <see cref="TargetNetworkId" /> property.</summary>
        private string _targetNetworkId;

        /// <summary>The target network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetNetworkId { get => this._targetNetworkId; set => this._targetNetworkId = value; }

        /// <summary>Backing field for <see cref="TargetProximityPlacementGroupId" /> property.</summary>
        private string _targetProximityPlacementGroupId;

        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProximityPlacementGroupId { get => this._targetProximityPlacementGroupId; set => this._targetProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="TargetResourceGroupId" /> property.</summary>
        private string _targetResourceGroupId;

        /// <summary>The target resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetResourceGroupId { get => this._targetResourceGroupId; set => this._targetResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetVMName" /> property.</summary>
        private string _targetVMName;

        /// <summary>Target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMName { get => this._targetVMName; set => this._targetVMName = value; }

        /// <summary>Backing field for <see cref="TargetVMSize" /> property.</summary>
        private string _targetVMSize;

        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMSize { get => this._targetVMSize; set => this._targetVMSize = value; }

        /// <summary>Backing field for <see cref="TestNetworkId" /> property.</summary>
        private string _testNetworkId;

        /// <summary>The test network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TestNetworkId { get => this._testNetworkId; set => this._testNetworkId = value; }

        /// <summary>Backing field for <see cref="VMNic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails[] _vMNic;

        /// <summary>The network details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails[] VMNic { get => this._vMNic; set => this._vMNic = value; }

        /// <summary>Creates an new <see cref="InMageRcmReplicationDetails" /> instance.</summary>
        public InMageRcmReplicationDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__replicationProviderSpecificSettings), __replicationProviderSpecificSettings);
            await eventListener.AssertObjectIsValid(nameof(__replicationProviderSpecificSettings), __replicationProviderSpecificSettings);
        }
    }
    /// InMageRcm provider specific details.
    public partial interface IInMageRcmReplicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings
    {
        /// <summary>The agent version to which last agent upgrade was attempted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The agent version to which last agent upgrade was attempted.",
        SerializedName = @"agentUpgradeAttemptToVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AgentUpgradeAttemptToVersion { get;  }
        /// <summary>The agent upgrade blocking error information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The agent upgrade blocking error information.",
        SerializedName = @"agentUpgradeBlockingErrorDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetails[] AgentUpgradeBlockingErrorDetail { get; set; }
        /// <summary>The agent upgrade job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The agent upgrade job Id.",
        SerializedName = @"agentUpgradeJobId",
        PossibleTypes = new [] { typeof(string) })]
        string AgentUpgradeJobId { get;  }
        /// <summary>The agent auto upgrade state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The agent auto upgrade state.",
        SerializedName = @"agentUpgradeState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MobilityAgentUpgradeState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MobilityAgentUpgradeState? AgentUpgradeState { get;  }
        /// <summary>The allocated memory in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The allocated memory in MB.",
        SerializedName = @"allocatedMemoryInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? AllocatedMemoryInMb { get;  }
        /// <summary>The type of the discovered VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the discovered VM.",
        SerializedName = @"discoveryType",
        PossibleTypes = new [] { typeof(string) })]
        string DiscoveryType { get;  }
        /// <summary>The ARM Id of the discovered VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the discovered VM.",
        SerializedName = @"fabricDiscoveryMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricDiscoveryMachineId { get;  }
        /// <summary>The recovery point Id to which the VM was failed over.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The recovery point Id to which the VM was failed over.",
        SerializedName = @"failoverRecoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string FailoverRecoveryPointId { get;  }
        /// <summary>The firmware type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The firmware type.",
        SerializedName = @"firmwareType",
        PossibleTypes = new [] { typeof(string) })]
        string FirmwareType { get;  }
        /// <summary>
        /// The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected
        /// disks in source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM.",
        SerializedName = @"initialReplicationProcessedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? InitialReplicationProcessedByte { get;  }
        /// <summary>The initial replication progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication progress health.",
        SerializedName = @"initialReplicationProgressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? InitialReplicationProgressHealth { get;  }
        /// <summary>
        /// The initial replication progress percentage. This is calculated based on total bytes processed for all disks in the source
        /// VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication progress percentage. This is calculated based on total bytes processed for all disks in the source VM.",
        SerializedName = @"initialReplicationProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? InitialReplicationProgressPercentage { get;  }
        /// <summary>
        /// The initial replication transferred bytes from source VM to azure for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication transferred bytes from source VM to azure for all selected disks on source VM.",
        SerializedName = @"initialReplicationTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? InitialReplicationTransferredByte { get;  }
        /// <summary>The virtual machine internal identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The virtual machine internal identifier.",
        SerializedName = @"internalIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string InternalIdentifier { get;  }
        /// <summary>A value indicating whether last agent upgrade was successful or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether last agent upgrade was successful or not.",
        SerializedName = @"isLastUpgradeSuccessful",
        PossibleTypes = new [] { typeof(string) })]
        string IsLastUpgradeSuccessful { get;  }
        /// <summary>The last agent upgrade error information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The last agent upgrade error information.",
        SerializedName = @"lastAgentUpgradeErrorDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetails[] LastAgentUpgradeErrorDetail { get; set; }
        /// <summary>The last agent upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last agent upgrade type.",
        SerializedName = @"lastAgentUpgradeType",
        PossibleTypes = new [] { typeof(string) })]
        string LastAgentUpgradeType { get;  }
        /// <summary>The last recovery point Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last recovery point Id.",
        SerializedName = @"lastRecoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string LastRecoveryPointId { get;  }
        /// <summary>The last recovery point received time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last recovery point received time.",
        SerializedName = @"lastRecoveryPointReceived",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastRecoveryPointReceived { get;  }
        /// <summary>The last recovery point objective calculated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last recovery point objective calculated time.",
        SerializedName = @"lastRpoCalculatedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastRpoCalculatedTime { get;  }
        /// <summary>The last recovery point objective value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last recovery point objective value.",
        SerializedName = @"lastRpoInSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? LastRpoInSecond { get;  }
        /// <summary>License Type of the VM to be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"License Type of the VM to be used.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(string) })]
        string LicenseType { get; set; }
        /// <summary>The agent version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The agent version expiry date.",
        SerializedName = @"agentVersionExpiryDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MobilityAgentDetailAgentVersionExpiryDate { get;  }
        /// <summary>The driver version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The driver version.",
        SerializedName = @"driverVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailDriverVersion { get;  }
        /// <summary>The driver version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The driver version expiry date.",
        SerializedName = @"driverVersionExpiryDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MobilityAgentDetailDriverVersionExpiryDate { get;  }
        /// <summary>A value indicating whether agent is upgradeable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether agent is upgradeable or not.",
        SerializedName = @"isUpgradeable",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailIsUpgradeable { get;  }
        /// <summary>The time of the last heartbeat received from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of the last heartbeat received from the agent.",
        SerializedName = @"lastHeartbeatUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MobilityAgentDetailLastHeartbeatUtc { get;  }
        /// <summary>The latest agent version release date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The latest agent version release date.",
        SerializedName = @"latestAgentReleaseDate",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailLatestAgentReleaseDate { get;  }
        /// <summary>The latest upgradeable version available without reboot.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The latest upgradeable version available without reboot.",
        SerializedName = @"latestUpgradableVersionWithoutReboot",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get;  }
        /// <summary>The latest agent version available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The latest agent version available.",
        SerializedName = @"latestVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailLatestVersion { get;  }
        /// <summary>The whether update is possible or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The whether update is possible or not.",
        SerializedName = @"reasonsBlockingUpgrade",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] MobilityAgentDetailReasonsBlockingUpgrade { get;  }
        /// <summary>The agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The agent version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailVersion { get;  }
        /// <summary>The multi VM group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The multi VM group name.",
        SerializedName = @"multiVmGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupName { get;  }
        /// <summary>The type of the OS on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the OS on the VM.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get;  }
        /// <summary>The IP address of the primary network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The IP address of the primary network interface.",
        SerializedName = @"primaryNicIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryNicIPAddress { get;  }
        /// <summary>The process server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The process server Id.",
        SerializedName = @"processServerId",
        PossibleTypes = new [] { typeof(string) })]
        string ProcessServerId { get;  }
        /// <summary>The process server name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The process server name.",
        SerializedName = @"processServerName",
        PossibleTypes = new [] { typeof(string) })]
        string ProcessServerName { get;  }
        /// <summary>The processor core count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The processor core count.",
        SerializedName = @"processorCoreCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ProcessorCoreCount { get;  }
        /// <summary>The list of protected disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of protected disks.",
        SerializedName = @"protectedDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetails[] ProtectedDisk { get; set; }
        /// <summary>
        /// The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source
        /// VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM.",
        SerializedName = @"resyncProcessedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncProcessedByte { get;  }
        /// <summary>The resync progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync progress health.",
        SerializedName = @"resyncProgressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? ResyncProgressHealth { get;  }
        /// <summary>
        /// The resync progress percentage. This is calculated based on total bytes processed for all disks in the source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync progress percentage. This is calculated based on total bytes processed for all disks in the source VM.",
        SerializedName = @"resyncProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ResyncProgressPercentage { get;  }
        /// <summary>A value indicating whether resync is required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether resync is required.",
        SerializedName = @"resyncRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncRequired { get;  }
        /// <summary>The resync state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync state.",
        SerializedName = @"resyncState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get;  }
        /// <summary>
        /// The resync transferred bytes from source VM to azure for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync transferred bytes from source VM to azure for all selected disks on source VM.",
        SerializedName = @"resyncTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncTransferredByte { get;  }
        /// <summary>The run-as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The run-as account Id.",
        SerializedName = @"runAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string RunAsAccountId { get;  }
        /// <summary>The target availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability set Id.",
        SerializedName = @"targetAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability zone.",
        SerializedName = @"targetAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilityZone { get; set; }
        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target boot diagnostics storage account ARM Id.",
        SerializedName = @"targetBootDiagnosticsStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary>The target generation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target generation.",
        SerializedName = @"targetGeneration",
        PossibleTypes = new [] { typeof(string) })]
        string TargetGeneration { get;  }
        /// <summary>The target location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target location.",
        SerializedName = @"targetLocation",
        PossibleTypes = new [] { typeof(string) })]
        string TargetLocation { get; set; }
        /// <summary>The target network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target network Id.",
        SerializedName = @"targetNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetNetworkId { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target proximity placement group Id.",
        SerializedName = @"targetProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target resource group Id.",
        SerializedName = @"targetResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGroupId { get; set; }
        /// <summary>Target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target VM name.",
        SerializedName = @"targetVmName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMName { get; set; }
        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM size.",
        SerializedName = @"targetVmSize",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMSize { get; set; }
        /// <summary>The test network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The test network Id.",
        SerializedName = @"testNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TestNetworkId { get; set; }
        /// <summary>The network details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network details.",
        SerializedName = @"vmNics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails[] VMNic { get; set; }

    }
    /// InMageRcm provider specific details.
    internal partial interface IInMageRcmReplicationDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal
    {
        /// <summary>The agent version to which last agent upgrade was attempted.</summary>
        string AgentUpgradeAttemptToVersion { get; set; }
        /// <summary>The agent upgrade blocking error information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetails[] AgentUpgradeBlockingErrorDetail { get; set; }
        /// <summary>The agent upgrade job Id.</summary>
        string AgentUpgradeJobId { get; set; }
        /// <summary>The agent auto upgrade state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MobilityAgentUpgradeState? AgentUpgradeState { get; set; }
        /// <summary>The allocated memory in MB.</summary>
        double? AllocatedMemoryInMb { get; set; }
        /// <summary>The type of the discovered VM.</summary>
        string DiscoveryType { get; set; }
        /// <summary>The ARM Id of the discovered VM.</summary>
        string FabricDiscoveryMachineId { get; set; }
        /// <summary>The recovery point Id to which the VM was failed over.</summary>
        string FailoverRecoveryPointId { get; set; }
        /// <summary>The firmware type.</summary>
        string FirmwareType { get; set; }
        /// <summary>
        /// The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected
        /// disks in source VM.
        /// </summary>
        long? InitialReplicationProcessedByte { get; set; }
        /// <summary>The initial replication progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? InitialReplicationProgressHealth { get; set; }
        /// <summary>
        /// The initial replication progress percentage. This is calculated based on total bytes processed for all disks in the source
        /// VM.
        /// </summary>
        int? InitialReplicationProgressPercentage { get; set; }
        /// <summary>
        /// The initial replication transferred bytes from source VM to azure for all selected disks on source VM.
        /// </summary>
        long? InitialReplicationTransferredByte { get; set; }
        /// <summary>The virtual machine internal identifier.</summary>
        string InternalIdentifier { get; set; }
        /// <summary>A value indicating whether last agent upgrade was successful or not.</summary>
        string IsLastUpgradeSuccessful { get; set; }
        /// <summary>The last agent upgrade error information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetails[] LastAgentUpgradeErrorDetail { get; set; }
        /// <summary>The last agent upgrade type.</summary>
        string LastAgentUpgradeType { get; set; }
        /// <summary>The last recovery point Id.</summary>
        string LastRecoveryPointId { get; set; }
        /// <summary>The last recovery point received time.</summary>
        global::System.DateTime? LastRecoveryPointReceived { get; set; }
        /// <summary>The last recovery point objective calculated time.</summary>
        global::System.DateTime? LastRpoCalculatedTime { get; set; }
        /// <summary>The last recovery point objective value.</summary>
        long? LastRpoInSecond { get; set; }
        /// <summary>License Type of the VM to be used.</summary>
        string LicenseType { get; set; }
        /// <summary>The mobility agent information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmMobilityAgentDetails MobilityAgentDetail { get; set; }
        /// <summary>The agent version expiry date.</summary>
        global::System.DateTime? MobilityAgentDetailAgentVersionExpiryDate { get; set; }
        /// <summary>The driver version.</summary>
        string MobilityAgentDetailDriverVersion { get; set; }
        /// <summary>The driver version expiry date.</summary>
        global::System.DateTime? MobilityAgentDetailDriverVersionExpiryDate { get; set; }
        /// <summary>A value indicating whether agent is upgradeable or not.</summary>
        string MobilityAgentDetailIsUpgradeable { get; set; }
        /// <summary>The time of the last heartbeat received from the agent.</summary>
        global::System.DateTime? MobilityAgentDetailLastHeartbeatUtc { get; set; }
        /// <summary>The latest agent version release date.</summary>
        string MobilityAgentDetailLatestAgentReleaseDate { get; set; }
        /// <summary>The latest upgradeable version available without reboot.</summary>
        string MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get; set; }
        /// <summary>The latest agent version available.</summary>
        string MobilityAgentDetailLatestVersion { get; set; }
        /// <summary>The whether update is possible or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] MobilityAgentDetailReasonsBlockingUpgrade { get; set; }
        /// <summary>The agent version.</summary>
        string MobilityAgentDetailVersion { get; set; }
        /// <summary>The multi VM group name.</summary>
        string MultiVMGroupName { get; set; }
        /// <summary>The type of the OS on the VM.</summary>
        string OSType { get; set; }
        /// <summary>The IP address of the primary network interface.</summary>
        string PrimaryNicIPAddress { get; set; }
        /// <summary>The process server Id.</summary>
        string ProcessServerId { get; set; }
        /// <summary>The process server name.</summary>
        string ProcessServerName { get; set; }
        /// <summary>The processor core count.</summary>
        int? ProcessorCoreCount { get; set; }
        /// <summary>The list of protected disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmProtectedDiskDetails[] ProtectedDisk { get; set; }
        /// <summary>
        /// The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source
        /// VM.
        /// </summary>
        long? ResyncProcessedByte { get; set; }
        /// <summary>The resync progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? ResyncProgressHealth { get; set; }
        /// <summary>
        /// The resync progress percentage. This is calculated based on total bytes processed for all disks in the source VM.
        /// </summary>
        int? ResyncProgressPercentage { get; set; }
        /// <summary>A value indicating whether resync is required.</summary>
        string ResyncRequired { get; set; }
        /// <summary>The resync state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get; set; }
        /// <summary>
        /// The resync transferred bytes from source VM to azure for all selected disks on source VM.
        /// </summary>
        long? ResyncTransferredByte { get; set; }
        /// <summary>The run-as account Id.</summary>
        string RunAsAccountId { get; set; }
        /// <summary>The target availability set Id.</summary>
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        string TargetAvailabilityZone { get; set; }
        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary>The target generation.</summary>
        string TargetGeneration { get; set; }
        /// <summary>The target location.</summary>
        string TargetLocation { get; set; }
        /// <summary>The target network Id.</summary>
        string TargetNetworkId { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group Id.</summary>
        string TargetResourceGroupId { get; set; }
        /// <summary>Target VM name.</summary>
        string TargetVMName { get; set; }
        /// <summary>The target VM size.</summary>
        string TargetVMSize { get; set; }
        /// <summary>The test network Id.</summary>
        string TestNetworkId { get; set; }
        /// <summary>The network details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails[] VMNic { get; set; }

    }
}