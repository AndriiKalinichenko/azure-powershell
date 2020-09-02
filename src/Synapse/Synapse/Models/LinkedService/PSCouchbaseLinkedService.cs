// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Couchbase server linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Couchbase")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSCouchbaseLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSCouchbaseLinkedService class.
        /// </summary>
        public PSCouchbaseLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an ODBC connection string. Type: string, SecureString
        /// or AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of credString in
        /// connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.credString")]
        public AzureKeyVaultSecretReference CredString { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new CouchbaseLinkedService();
            linkedService.ConnectionString = this.ConnectionString;
            linkedService.CredString = this.CredString;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            SetProperties(linkedService);
            return linkedService;
        }
    }
}

