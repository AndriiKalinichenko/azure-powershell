namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm source agent upgrade blocking error details.</summary>
    public partial class InMageRcmAgentUpgradeBlockingErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsInternal
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
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters _errorMessageParameter;

        /// <summary>The error message parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters ErrorMessageParameter { get => (this._errorMessageParameter = this._errorMessageParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters()); }

        /// <summary>Backing field for <see cref="ErrorTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorTags _errorTag;

        /// <summary>The error tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorTags ErrorTag { get => (this._errorTag = this._errorTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmAgentUpgradeBlockingErrorDetailsErrorTags()); }

        /// <summary>Internal Acessors for ErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsInternal.ErrorCode { get => this._errorCode; set { {_errorCode = value;} } }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsInternal.ErrorMessage { get => this._errorMessage; set { {_errorMessage = value;} } }

        /// <summary>Internal Acessors for ErrorMessageParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsInternal.ErrorMessageParameter { get => (this._errorMessageParameter = this._errorMessageParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters()); set { {_errorMessageParameter = value;} } }

        /// <summary>Internal Acessors for ErrorTag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorTags Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsInternal.ErrorTag { get => (this._errorTag = this._errorTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmAgentUpgradeBlockingErrorDetailsErrorTags()); set { {_errorTag = value;} } }

        /// <summary>Internal Acessors for PossibleCaus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsInternal.PossibleCaus { get => this._possibleCaus; set { {_possibleCaus = value;} } }

        /// <summary>Internal Acessors for RecommendedAction</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsInternal.RecommendedAction { get => this._recommendedAction; set { {_recommendedAction = value;} } }

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

        /// <summary>
        /// Creates an new <see cref="InMageRcmAgentUpgradeBlockingErrorDetails" /> instance.
        /// </summary>
        public InMageRcmAgentUpgradeBlockingErrorDetails()
        {

        }
    }
    /// InMageRcm source agent upgrade blocking error details.
    public partial interface IInMageRcmAgentUpgradeBlockingErrorDetails :
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
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters ErrorMessageParameter { get;  }
        /// <summary>The error tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error tags.",
        SerializedName = @"errorTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorTags ErrorTag { get;  }
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
    /// InMageRcm source agent upgrade blocking error details.
    internal partial interface IInMageRcmAgentUpgradeBlockingErrorDetailsInternal

    {
        /// <summary>The error code.</summary>
        string ErrorCode { get; set; }
        /// <summary>The error message.</summary>
        string ErrorMessage { get; set; }
        /// <summary>The error message parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorMessageParameters ErrorMessageParameter { get; set; }
        /// <summary>The error tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmAgentUpgradeBlockingErrorDetailsErrorTags ErrorTag { get; set; }
        /// <summary>The possible causes.</summary>
        string PossibleCaus { get; set; }
        /// <summary>The recommended action.</summary>
        string RecommendedAction { get; set; }

    }
}