namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Agent disk details.</summary>
    public partial class AgentDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="CapacityInByte" /> property.</summary>
        private long? _capacityInByte;

        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? CapacityInByte { get => this._capacityInByte; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; }

        /// <summary>Backing field for <see cref="DiskName" /> property.</summary>
        private string _diskName;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskName { get => this._diskName; }

        /// <summary>Backing field for <see cref="IsOSDisk" /> property.</summary>
        private string _isOSDisk;

        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsOSDisk { get => this._isOSDisk; }

        /// <summary>Backing field for <see cref="LunId" /> property.</summary>
        private int? _lunId;

        /// <summary>The lun of disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? LunId { get => this._lunId; }

        /// <summary>Internal Acessors for CapacityInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetailsInternal.CapacityInByte { get => this._capacityInByte; set { {_capacityInByte = value;} } }

        /// <summary>Internal Acessors for DiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetailsInternal.DiskId { get => this._diskId; set { {_diskId = value;} } }

        /// <summary>Internal Acessors for DiskName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetailsInternal.DiskName { get => this._diskName; set { {_diskName = value;} } }

        /// <summary>Internal Acessors for IsOSDisk</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetailsInternal.IsOSDisk { get => this._isOSDisk; set { {_isOSDisk = value;} } }

        /// <summary>Internal Acessors for LunId</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetailsInternal.LunId { get => this._lunId; set { {_lunId = value;} } }

        /// <summary>Creates an new <see cref="AgentDiskDetails" /> instance.</summary>
        public AgentDiskDetails()
        {

        }
    }
    /// Agent disk details.
    public partial interface IAgentDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk capacity in bytes.",
        SerializedName = @"capacityInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityInByte { get;  }
        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk Id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get;  }
        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk name.",
        SerializedName = @"diskName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskName { get;  }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the disk is the OS disk.",
        SerializedName = @"isOSDisk",
        PossibleTypes = new [] { typeof(string) })]
        string IsOSDisk { get;  }
        /// <summary>The lun of disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The lun of disk.",
        SerializedName = @"lunId",
        PossibleTypes = new [] { typeof(int) })]
        int? LunId { get;  }

    }
    /// Agent disk details.
    internal partial interface IAgentDiskDetailsInternal

    {
        /// <summary>The disk capacity in bytes.</summary>
        long? CapacityInByte { get; set; }
        /// <summary>The disk Id.</summary>
        string DiskId { get; set; }
        /// <summary>The disk name.</summary>
        string DiskName { get; set; }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        string IsOSDisk { get; set; }
        /// <summary>The lun of disk.</summary>
        int? LunId { get; set; }

    }
}