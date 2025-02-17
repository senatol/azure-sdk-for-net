// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An export managed database operation result resource. </summary>
    public partial class SqlDatabaseExtension : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseExtension"/>. </summary>
        public SqlDatabaseExtension()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseExtension"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="operationMode"> Operation Mode. </param>
        /// <param name="storageKeyType"> Storage key type. </param>
        /// <param name="storageKey"> Storage key. </param>
        /// <param name="storageUri"> Storage Uri. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlDatabaseExtension(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DatabaseExtensionOperationMode? operationMode, StorageKeyType? storageKeyType, string storageKey, Uri storageUri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            OperationMode = operationMode;
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Operation Mode. </summary>
        public DatabaseExtensionOperationMode? OperationMode { get; set; }
        /// <summary> Storage key type. </summary>
        public StorageKeyType? StorageKeyType { get; set; }
        /// <summary> Storage key. </summary>
        public string StorageKey { get; set; }
        /// <summary> Storage Uri. </summary>
        public Uri StorageUri { get; set; }
    }
}
