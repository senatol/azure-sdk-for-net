// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Preferences related to the order. </summary>
    public partial class OrderItemPreferences
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

        /// <summary> Initializes a new instance of <see cref="OrderItemPreferences"/>. </summary>
        public OrderItemPreferences()
        {
            NotificationPreferences = new ChangeTrackingList<NotificationPreference>();
        }

        /// <summary> Initializes a new instance of <see cref="OrderItemPreferences"/>. </summary>
        /// <param name="notificationPreferences"> Notification preferences. </param>
        /// <param name="transportPreferences"> Preferences related to the shipment logistics of the order. </param>
        /// <param name="encryptionPreferences"> Preferences related to the Encryption. </param>
        /// <param name="managementResourcePreferences"> Preferences related to the Management resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OrderItemPreferences(IList<NotificationPreference> notificationPreferences, TransportPreferences transportPreferences, EncryptionPreferences encryptionPreferences, ManagementResourcePreferences managementResourcePreferences, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NotificationPreferences = notificationPreferences;
            TransportPreferences = transportPreferences;
            EncryptionPreferences = encryptionPreferences;
            ManagementResourcePreferences = managementResourcePreferences;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Notification preferences. </summary>
        public IList<NotificationPreference> NotificationPreferences { get; }
        /// <summary> Preferences related to the shipment logistics of the order. </summary>
        internal TransportPreferences TransportPreferences { get; set; }
        /// <summary> Indicates Shipment Logistics type that the customer preferred. </summary>
        public TransportShipmentType? TransportPreferencesPreferredShipmentType
        {
            get => TransportPreferences is null ? default(TransportShipmentType?) : TransportPreferences.PreferredShipmentType;
            set
            {
                TransportPreferences = value.HasValue ? new TransportPreferences(value.Value) : null;
            }
        }

        /// <summary> Preferences related to the Encryption. </summary>
        internal EncryptionPreferences EncryptionPreferences { get; set; }
        /// <summary> Double encryption status as entered by the customer. It is compulsory to give this parameter if the 'Deny' or 'Disabled' policy is configured. </summary>
        public DoubleEncryptionStatus? DoubleEncryptionStatus
        {
            get => EncryptionPreferences is null ? default : EncryptionPreferences.DoubleEncryptionStatus;
            set
            {
                if (EncryptionPreferences is null)
                    EncryptionPreferences = new EncryptionPreferences();
                EncryptionPreferences.DoubleEncryptionStatus = value;
            }
        }

        /// <summary> Preferences related to the Management resource. </summary>
        internal ManagementResourcePreferences ManagementResourcePreferences { get; set; }
        /// <summary> Customer preferred Management resource ARM ID. </summary>
        public string PreferredManagementResourceId
        {
            get => ManagementResourcePreferences is null ? default : ManagementResourcePreferences.PreferredManagementResourceId;
            set
            {
                if (ManagementResourcePreferences is null)
                    ManagementResourcePreferences = new ManagementResourcePreferences();
                ManagementResourcePreferences.PreferredManagementResourceId = value;
            }
        }
    }
}
