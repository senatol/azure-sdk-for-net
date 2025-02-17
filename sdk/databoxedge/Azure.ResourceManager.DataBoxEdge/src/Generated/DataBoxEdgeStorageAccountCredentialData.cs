// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeStorageAccountCredential data model.
    /// The storage account credential.
    /// </summary>
    public partial class DataBoxEdgeStorageAccountCredentialData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeStorageAccountCredentialData"/>. </summary>
        /// <param name="alias"> Alias for the storage account. </param>
        /// <param name="sslStatus"> Signifies whether SSL needs to be enabled or not. </param>
        /// <param name="accountType"> Type of storage accessed on the storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public DataBoxEdgeStorageAccountCredentialData(string @alias, DataBoxEdgeStorageAccountSslStatus sslStatus, DataBoxEdgeStorageAccountType accountType)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            Alias = @alias;
            SslStatus = sslStatus;
            AccountType = accountType;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeStorageAccountCredentialData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="alias"> Alias for the storage account. </param>
        /// <param name="userName"> Username for the storage account. </param>
        /// <param name="accountKey"> Encrypted storage key. </param>
        /// <param name="connectionString"> Connection string for the storage account. Use this string if username and account key are not specified. </param>
        /// <param name="sslStatus"> Signifies whether SSL needs to be enabled or not. </param>
        /// <param name="blobDomainName"> Blob end point for private clouds. </param>
        /// <param name="accountType"> Type of storage accessed on the storage account. </param>
        /// <param name="storageAccountId"> Id of the storage account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeStorageAccountCredentialData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string @alias, string userName, AsymmetricEncryptedSecret accountKey, string connectionString, DataBoxEdgeStorageAccountSslStatus sslStatus, string blobDomainName, DataBoxEdgeStorageAccountType accountType, ResourceIdentifier storageAccountId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Alias = @alias;
            UserName = userName;
            AccountKey = accountKey;
            ConnectionString = connectionString;
            SslStatus = sslStatus;
            BlobDomainName = blobDomainName;
            AccountType = accountType;
            StorageAccountId = storageAccountId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeStorageAccountCredentialData"/> for deserialization. </summary>
        internal DataBoxEdgeStorageAccountCredentialData()
        {
        }

        /// <summary> Alias for the storage account. </summary>
        public string Alias { get; set; }
        /// <summary> Username for the storage account. </summary>
        public string UserName { get; set; }
        /// <summary> Encrypted storage key. </summary>
        public AsymmetricEncryptedSecret AccountKey { get; set; }
        /// <summary> Connection string for the storage account. Use this string if username and account key are not specified. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Signifies whether SSL needs to be enabled or not. </summary>
        public DataBoxEdgeStorageAccountSslStatus SslStatus { get; set; }
        /// <summary> Blob end point for private clouds. </summary>
        public string BlobDomainName { get; set; }
        /// <summary> Type of storage accessed on the storage account. </summary>
        public DataBoxEdgeStorageAccountType AccountType { get; set; }
        /// <summary> Id of the storage account. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
    }
}
