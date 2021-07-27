namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageAzureV2 provider specific input for unplanned failover.</summary>
    public partial class InMageAzureV2UnplannedFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UnplannedFailoverInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UnplannedFailoverInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInput __unplannedFailoverProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UnplannedFailoverProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInputInternal)__unplannedFailoverProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInputInternal)__unplannedFailoverProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointId" /> property.</summary>
        private string _recoveryPointId;

        /// <summary>
        /// The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryPointId { get => this._recoveryPointId; set => this._recoveryPointId = value; }

        /// <summary>Creates an new <see cref="InMageAzureV2UnplannedFailoverInput" /> instance.</summary>
        public InMageAzureV2UnplannedFailoverInput()
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
            await eventListener.AssertNotNull(nameof(__unplannedFailoverProviderSpecificInput), __unplannedFailoverProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__unplannedFailoverProviderSpecificInput), __unplannedFailoverProviderSpecificInput);
        }
    }
    /// InMageAzureV2 provider specific input for unplanned failover.
    public partial interface IInMageAzureV2UnplannedFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInput
    {
        /// <summary>
        /// The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed.",
        SerializedName = @"recoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointId { get; set; }

    }
    /// InMageAzureV2 provider specific input for unplanned failover.
    internal partial interface IInMageAzureV2UnplannedFailoverInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUnplannedFailoverProviderSpecificInputInternal
    {
        /// <summary>
        /// The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        string RecoveryPointId { get; set; }

    }
}