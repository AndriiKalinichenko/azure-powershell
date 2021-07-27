namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    /// <summary>The recoverable server's properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(RecoverableServerPropertiesTypeConverter))]
    public partial class RecoverableServerProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.RecoverableServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoverableServerProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.RecoverableServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoverableServerProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoverableServerProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.RecoverableServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoverableServerProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).LastAvailableBackupDateTime = (string) content.GetValueForProperty("LastAvailableBackupDateTime",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).LastAvailableBackupDateTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).ServiceLevelObjective = (string) content.GetValueForProperty("ServiceLevelObjective",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).ServiceLevelObjective, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Edition = (string) content.GetValueForProperty("Edition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Edition, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).VCore = (int?) content.GetValueForProperty("VCore",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).VCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).HardwareGeneration = (string) content.GetValueForProperty("HardwareGeneration",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).HardwareGeneration, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.RecoverableServerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoverableServerProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).LastAvailableBackupDateTime = (string) content.GetValueForProperty("LastAvailableBackupDateTime",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).LastAvailableBackupDateTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).ServiceLevelObjective = (string) content.GetValueForProperty("ServiceLevelObjective",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).ServiceLevelObjective, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Edition = (string) content.GetValueForProperty("Edition",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Edition, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).VCore = (int?) content.GetValueForProperty("VCore",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).VCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).HardwareGeneration = (string) content.GetValueForProperty("HardwareGeneration",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).HardwareGeneration, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The recoverable server's properties.
    [System.ComponentModel.TypeConverter(typeof(RecoverableServerPropertiesTypeConverter))]
    public partial interface IRecoverableServerProperties

    {

    }
}