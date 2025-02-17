// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthBot.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthBot
{
    /// <summary>
    /// A class representing the HealthBot data model.
    /// Azure Health Bot resource definition
    /// </summary>
    public partial class HealthBotData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="HealthBotData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the Azure Health Bot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public HealthBotData(AzureLocation location, HealthBotSku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
        }

        /// <summary> Initializes a new instance of <see cref="HealthBotData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the Azure Health Bot. </param>
        /// <param name="identity"> The identity of the Azure Health Bot. </param>
        /// <param name="properties"> The set of properties specific to Azure Health Bot resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthBotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HealthBotSku sku, ManagedServiceIdentity identity, HealthBotProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthBotData"/> for deserialization. </summary>
        internal HealthBotData()
        {
        }

        /// <summary> SKU of the Azure Health Bot. </summary>
        internal HealthBotSku Sku { get; set; }
        /// <summary> The name of the Azure Health Bot SKU. </summary>
        public HealthBotSkuName? SkuName
        {
            get => Sku is null ? default(HealthBotSkuName?) : Sku.Name;
            set
            {
                Sku = value.HasValue ? new HealthBotSku(value.Value) : null;
            }
        }

        /// <summary> The identity of the Azure Health Bot. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The set of properties specific to Azure Health Bot resource. </summary>
        public HealthBotProperties Properties { get; set; }
    }
}
