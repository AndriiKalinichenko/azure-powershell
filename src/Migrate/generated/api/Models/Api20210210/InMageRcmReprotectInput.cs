namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm specific provider input.</summary>
    public partial class InMageRcmReprotectInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReprotectInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmReprotectInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReverseReplicationProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReverseReplicationProviderSpecificInput __reverseReplicationProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReverseReplicationProviderSpecificInput();

        /// <summary>Backing field for <see cref="DatastoreName" /> property.</summary>
        private string _datastoreName;

        /// <summary>The target datastore name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DatastoreName { get => this._datastoreName; set => this._datastoreName = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReverseReplicationProviderSpecificInputInternal)__reverseReplicationProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReverseReplicationProviderSpecificInputInternal)__reverseReplicationProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="LogStorageAccountId" /> property.</summary>
        private string _logStorageAccountId;

        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountId { get => this._logStorageAccountId; set => this._logStorageAccountId = value; }

        /// <summary>Backing field for <see cref="PolicyId" /> property.</summary>
        private string _policyId;

        /// <summary>The Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PolicyId { get => this._policyId; set => this._policyId = value; }

        /// <summary>Backing field for <see cref="ReprotectAgentId" /> property.</summary>
        private string _reprotectAgentId;

        /// <summary>The reprotect agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ReprotectAgentId { get => this._reprotectAgentId; set => this._reprotectAgentId = value; }

        /// <summary>Creates an new <see cref="InMageRcmReprotectInput" /> instance.</summary>
        public InMageRcmReprotectInput()
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
            await eventListener.AssertNotNull(nameof(__reverseReplicationProviderSpecificInput), __reverseReplicationProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__reverseReplicationProviderSpecificInput), __reverseReplicationProviderSpecificInput);
        }
    }
    /// InMageRcm specific provider input.
    public partial interface IInMageRcmReprotectInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReverseReplicationProviderSpecificInput
    {
        /// <summary>The target datastore name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The target datastore name.",
        SerializedName = @"datastoreName",
        PossibleTypes = new [] { typeof(string) })]
        string DatastoreName { get; set; }
        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The log storage account ARM Id.",
        SerializedName = @"logStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountId { get; set; }
        /// <summary>The Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Policy Id.",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get; set; }
        /// <summary>The reprotect agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The reprotect agent Id.",
        SerializedName = @"reprotectAgentId",
        PossibleTypes = new [] { typeof(string) })]
        string ReprotectAgentId { get; set; }

    }
    /// InMageRcm specific provider input.
    internal partial interface IInMageRcmReprotectInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReverseReplicationProviderSpecificInputInternal
    {
        /// <summary>The target datastore name.</summary>
        string DatastoreName { get; set; }
        /// <summary>The log storage account ARM Id.</summary>
        string LogStorageAccountId { get; set; }
        /// <summary>The Policy Id.</summary>
        string PolicyId { get; set; }
        /// <summary>The reprotect agent Id.</summary>
        string ReprotectAgentId { get; set; }

    }
}