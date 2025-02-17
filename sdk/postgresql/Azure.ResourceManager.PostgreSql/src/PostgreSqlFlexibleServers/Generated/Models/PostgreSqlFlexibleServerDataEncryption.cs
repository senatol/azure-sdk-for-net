// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Data encryption properties of a server. </summary>
    public partial class PostgreSqlFlexibleServerDataEncryption
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerDataEncryption"/>. </summary>
        public PostgreSqlFlexibleServerDataEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerDataEncryption"/>. </summary>
        /// <param name="primaryKeyUri"> URI for the key in keyvault for data encryption of the primary server. </param>
        /// <param name="primaryUserAssignedIdentityId"> Resource Id for the User assigned identity to be used for data encryption of the primary server. </param>
        /// <param name="geoBackupKeyUri"> URI for the key in keyvault for data encryption for geo-backup of server. </param>
        /// <param name="geoBackupUserAssignedIdentityId"> Resource Id for the User assigned identity to be used for data encryption for geo-backup of server. </param>
        /// <param name="keyType"> Data encryption type to depict if it is System Managed vs Azure Key vault. </param>
        /// <param name="primaryEncryptionKeyStatus"> Primary encryption key status for Data encryption enabled server. </param>
        /// <param name="geoBackupEncryptionKeyStatus"> Geo-backup encryption key status for Data encryption enabled server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerDataEncryption(Uri primaryKeyUri, ResourceIdentifier primaryUserAssignedIdentityId, Uri geoBackupKeyUri, string geoBackupUserAssignedIdentityId, PostgreSqlFlexibleServerKeyType? keyType, PostgreSqlKeyStatus? primaryEncryptionKeyStatus, PostgreSqlKeyStatus? geoBackupEncryptionKeyStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryKeyUri = primaryKeyUri;
            PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
            GeoBackupKeyUri = geoBackupKeyUri;
            GeoBackupUserAssignedIdentityId = geoBackupUserAssignedIdentityId;
            KeyType = keyType;
            PrimaryEncryptionKeyStatus = primaryEncryptionKeyStatus;
            GeoBackupEncryptionKeyStatus = geoBackupEncryptionKeyStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> URI for the key in keyvault for data encryption of the primary server. </summary>
        public Uri PrimaryKeyUri { get; set; }
        /// <summary> Resource Id for the User assigned identity to be used for data encryption of the primary server. </summary>
        public ResourceIdentifier PrimaryUserAssignedIdentityId { get; set; }
        /// <summary> URI for the key in keyvault for data encryption for geo-backup of server. </summary>
        public Uri GeoBackupKeyUri { get; set; }
        /// <summary> Resource Id for the User assigned identity to be used for data encryption for geo-backup of server. </summary>
        public string GeoBackupUserAssignedIdentityId { get; set; }
        /// <summary> Data encryption type to depict if it is System Managed vs Azure Key vault. </summary>
        public PostgreSqlFlexibleServerKeyType? KeyType { get; set; }
        /// <summary> Primary encryption key status for Data encryption enabled server. </summary>
        public PostgreSqlKeyStatus? PrimaryEncryptionKeyStatus { get; set; }
        /// <summary> Geo-backup encryption key status for Data encryption enabled server. </summary>
        public PostgreSqlKeyStatus? GeoBackupEncryptionKeyStatus { get; set; }
    }
}
