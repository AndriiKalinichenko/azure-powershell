namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A provider specific settings.</summary>
    public partial class A2ACrossClusterMigrationReplicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings __replicationProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReplicationProviderSpecificSettings();

        /// <summary>Backing field for <see cref="FabricObjectId" /> property.</summary>
        private string _fabricObjectId;

        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricObjectId { get => this._fabricObjectId; set => this._fabricObjectId = value; }

        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType; }

        /// <summary>Backing field for <see cref="LifecycleId" /> property.</summary>
        private string _lifecycleId;

        /// <summary>
        /// An id associated with the PE that survives actions like switch protection which change the backing PE/CPE objects internally.The
        /// lifecycle id gets carried forward to have a link/continuity in being able to have an Id that denotes the "same" protected
        /// item even though other internal Ids/ARM Id might be changing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LifecycleId { get => this._lifecycleId; set => this._lifecycleId = value; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The type of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="PrimaryFabricLocation" /> property.</summary>
        private string _primaryFabricLocation;

        /// <summary>Primary fabric location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PrimaryFabricLocation { get => this._primaryFabricLocation; set => this._primaryFabricLocation = value; }

        /// <summary>Backing field for <see cref="VMProtectionState" /> property.</summary>
        private string _vMProtectionState;

        /// <summary>The protection state for the vm.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VMProtectionState { get => this._vMProtectionState; set => this._vMProtectionState = value; }

        /// <summary>Backing field for <see cref="VMProtectionStateDescription" /> property.</summary>
        private string _vMProtectionStateDescription;

        /// <summary>The protection state description for the vm.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VMProtectionStateDescription { get => this._vMProtectionStateDescription; set => this._vMProtectionStateDescription = value; }

        /// <summary>
        /// Creates an new <see cref="A2ACrossClusterMigrationReplicationDetails" /> instance.
        /// </summary>
        public A2ACrossClusterMigrationReplicationDetails()
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
    /// A2A provider specific settings.
    public partial interface IA2ACrossClusterMigrationReplicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings
    {
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fabric specific object Id of the virtual machine.",
        SerializedName = @"fabricObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectId { get; set; }
        /// <summary>
        /// An id associated with the PE that survives actions like switch protection which change the backing PE/CPE objects internally.The
        /// lifecycle id gets carried forward to have a link/continuity in being able to have an Id that denotes the "same" protected
        /// item even though other internal Ids/ARM Id might be changing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An id associated with the PE that survives actions like switch protection which change the backing PE/CPE objects internally.The lifecycle id gets carried forward to have a link/continuity in being able to have an Id that denotes the ""same"" protected item even though other internal Ids/ARM Id might be changing.",
        SerializedName = @"lifecycleId",
        PossibleTypes = new [] { typeof(string) })]
        string LifecycleId { get; set; }
        /// <summary>The type of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of operating system.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>Primary fabric location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary fabric location.",
        SerializedName = @"primaryFabricLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryFabricLocation { get; set; }
        /// <summary>The protection state for the vm.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The protection state for the vm.",
        SerializedName = @"vmProtectionState",
        PossibleTypes = new [] { typeof(string) })]
        string VMProtectionState { get; set; }
        /// <summary>The protection state description for the vm.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The protection state description for the vm.",
        SerializedName = @"vmProtectionStateDescription",
        PossibleTypes = new [] { typeof(string) })]
        string VMProtectionStateDescription { get; set; }

    }
    /// A2A provider specific settings.
    internal partial interface IA2ACrossClusterMigrationReplicationDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal
    {
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        string FabricObjectId { get; set; }
        /// <summary>
        /// An id associated with the PE that survives actions like switch protection which change the backing PE/CPE objects internally.The
        /// lifecycle id gets carried forward to have a link/continuity in being able to have an Id that denotes the "same" protected
        /// item even though other internal Ids/ARM Id might be changing.
        /// </summary>
        string LifecycleId { get; set; }
        /// <summary>The type of operating system.</summary>
        string OSType { get; set; }
        /// <summary>Primary fabric location.</summary>
        string PrimaryFabricLocation { get; set; }
        /// <summary>The protection state for the vm.</summary>
        string VMProtectionState { get; set; }
        /// <summary>The protection state description for the vm.</summary>
        string VMProtectionStateDescription { get; set; }

    }
}