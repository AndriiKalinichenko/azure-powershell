namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>This class represents the virtual machine task details.</summary>
    public partial class VirtualMachineTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVirtualMachineTaskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVirtualMachineTaskDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetails __jobTaskDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.JobTaskDetails();

        /// <summary>The type of task details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetailsInternal)__jobTaskDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetailsInternal)__jobTaskDetails).InstanceType = value ?? null; }

        /// <summary>The job entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntity JobTask { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTask; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTask = value ?? null /* model class */; }

        /// <summary>The job display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string JobTaskJobFriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskJobFriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskJobFriendlyName = value ?? null; }

        /// <summary>The job id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string JobTaskJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskJobId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskJobId = value ?? null; }

        /// <summary>The job name. Enum type ScenarioName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string JobTaskJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskJobScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskJobScenarioName = value ?? null; }

        /// <summary>The workflow affected object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string JobTaskTargetInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskTargetInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskTargetInstanceType = value ?? null; }

        /// <summary>The object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string JobTaskTargetObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskTargetObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskTargetObjectId = value ?? null; }

        /// <summary>The object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string JobTaskTargetObjectName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskTargetObjectName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal)__jobTaskDetails).JobTaskTargetObjectName = value ?? null; }

        /// <summary>Backing field for <see cref="SkippedReason" /> property.</summary>
        private string _skippedReason;

        /// <summary>The skipped reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SkippedReason { get => this._skippedReason; set => this._skippedReason = value; }

        /// <summary>Backing field for <see cref="SkippedReasonString" /> property.</summary>
        private string _skippedReasonString;

        /// <summary>The skipped reason string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SkippedReasonString { get => this._skippedReasonString; set => this._skippedReasonString = value; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobTaskDetails), __jobTaskDetails);
            await eventListener.AssertObjectIsValid(nameof(__jobTaskDetails), __jobTaskDetails);
        }

        /// <summary>Creates an new <see cref="VirtualMachineTaskDetails" /> instance.</summary>
        public VirtualMachineTaskDetails()
        {

        }
    }
    /// This class represents the virtual machine task details.
    public partial interface IVirtualMachineTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetails
    {
        /// <summary>The skipped reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The skipped reason.",
        SerializedName = @"skippedReason",
        PossibleTypes = new [] { typeof(string) })]
        string SkippedReason { get; set; }
        /// <summary>The skipped reason string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The skipped reason string.",
        SerializedName = @"skippedReasonString",
        PossibleTypes = new [] { typeof(string) })]
        string SkippedReasonString { get; set; }

    }
    /// This class represents the virtual machine task details.
    internal partial interface IVirtualMachineTaskDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal
    {
        /// <summary>The skipped reason.</summary>
        string SkippedReason { get; set; }
        /// <summary>The skipped reason string.</summary>
        string SkippedReasonString { get; set; }

    }
}