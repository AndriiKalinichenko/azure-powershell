namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm last source agent upgrade error details.</summary>
    public partial class InMageRcmLastAgentUpgradeErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsInternal
    {

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private string _errorCode;

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ErrorCode { get => this._errorCode; }

        /// <summary>Backing field for <see cref="ErrorMessage" /> property.</summary>
        private string _errorMessage;

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ErrorMessage { get => this._errorMessage; }

        /// <summary>Backing field for <see cref="ErrorMessageParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters _errorMessageParameter;

        /// <summary>The error message parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters ErrorMessageParameter { get => (this._errorMessageParameter = this._errorMessageParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters()); }

        /// <summary>Backing field for <see cref="ErrorTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorTags _errorTag;

        /// <summary>The error tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorTags ErrorTag { get => (this._errorTag = this._errorTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmLastAgentUpgradeErrorDetailsErrorTags()); }

        /// <summary>Internal Acessors for ErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsInternal.ErrorCode { get => this._errorCode; set { {_errorCode = value;} } }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsInternal.ErrorMessage { get => this._errorMessage; set { {_errorMessage = value;} } }

        /// <summary>Internal Acessors for ErrorMessageParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsInternal.ErrorMessageParameter { get => (this._errorMessageParameter = this._errorMessageParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters()); set { {_errorMessageParameter = value;} } }

        /// <summary>Internal Acessors for ErrorTag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorTags Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsInternal.ErrorTag { get => (this._errorTag = this._errorTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmLastAgentUpgradeErrorDetailsErrorTags()); set { {_errorTag = value;} } }

        /// <summary>Internal Acessors for PossibleCaus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsInternal.PossibleCaus { get => this._possibleCaus; set { {_possibleCaus = value;} } }

        /// <summary>Internal Acessors for RecommendedAction</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsInternal.RecommendedAction { get => this._recommendedAction; set { {_recommendedAction = value;} } }

        /// <summary>Backing field for <see cref="PossibleCaus" /> property.</summary>
        private string _possibleCaus;

        /// <summary>The possible causes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PossibleCaus { get => this._possibleCaus; }

        /// <summary>Backing field for <see cref="RecommendedAction" /> property.</summary>
        private string _recommendedAction;

        /// <summary>The recommended action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecommendedAction { get => this._recommendedAction; }

        /// <summary>Creates an new <see cref="InMageRcmLastAgentUpgradeErrorDetails" /> instance.</summary>
        public InMageRcmLastAgentUpgradeErrorDetails()
        {

        }
    }
    /// InMageRcm last source agent upgrade error details.
    public partial interface IInMageRcmLastAgentUpgradeErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorCode { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get;  }
        /// <summary>The error message parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message parameters.",
        SerializedName = @"errorMessageParameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters ErrorMessageParameter { get;  }
        /// <summary>The error tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error tags.",
        SerializedName = @"errorTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorTags ErrorTag { get;  }
        /// <summary>The possible causes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The possible causes.",
        SerializedName = @"possibleCauses",
        PossibleTypes = new [] { typeof(string) })]
        string PossibleCaus { get;  }
        /// <summary>The recommended action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The recommended action.",
        SerializedName = @"recommendedAction",
        PossibleTypes = new [] { typeof(string) })]
        string RecommendedAction { get;  }

    }
    /// InMageRcm last source agent upgrade error details.
    internal partial interface IInMageRcmLastAgentUpgradeErrorDetailsInternal

    {
        /// <summary>The error code.</summary>
        string ErrorCode { get; set; }
        /// <summary>The error message.</summary>
        string ErrorMessage { get; set; }
        /// <summary>The error message parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorMessageParameters ErrorMessageParameter { get; set; }
        /// <summary>The error tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmLastAgentUpgradeErrorDetailsErrorTags ErrorTag { get; set; }
        /// <summary>The possible causes.</summary>
        string PossibleCaus { get; set; }
        /// <summary>The recommended action.</summary>
        string RecommendedAction { get; set; }

    }
}