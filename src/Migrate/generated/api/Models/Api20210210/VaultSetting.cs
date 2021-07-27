namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Vault setting.</summary>
    public partial class VaultSetting :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSetting,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.Resource();

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; }

        /// <summary>Resource Location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultSettingProperties()); set { {_property = value;} } }

        /// <summary>The migration solution ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MigrationSolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingPropertiesInternal)Property).MigrationSolutionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingPropertiesInternal)Property).MigrationSolutionId = value ?? null; }

        /// <summary>Resource Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingProperties _property;

        /// <summary>The vault setting properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultSettingProperties()); set => this._property = value; }

        /// <summary>Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }

        /// <summary>Creates an new <see cref="VaultSetting" /> instance.</summary>
        public VaultSetting()
        {

        }
    }
    /// Vault setting.
    public partial interface IVaultSetting :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource
    {
        /// <summary>The migration solution ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The migration solution ARM Id.",
        SerializedName = @"migrationSolutionId",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationSolutionId { get; set; }

    }
    /// Vault setting.
    internal partial interface IVaultSettingInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal
    {
        /// <summary>The migration solution ARM Id.</summary>
        string MigrationSolutionId { get; set; }
        /// <summary>The vault setting properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingProperties Property { get; set; }

    }
}