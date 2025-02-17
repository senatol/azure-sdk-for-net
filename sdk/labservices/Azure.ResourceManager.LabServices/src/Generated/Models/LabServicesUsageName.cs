// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The Usage Names. </summary>
    public partial class LabServicesUsageName
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

        /// <summary> Initializes a new instance of <see cref="LabServicesUsageName"/>. </summary>
        internal LabServicesUsageName()
        {
            SkuInstances = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LabServicesUsageName"/>. </summary>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        /// <param name="skuInstances"> The instances of the resource. </param>
        /// <param name="value"> The name of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabServicesUsageName(string localizedValue, IReadOnlyList<string> skuInstances, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LocalizedValue = localizedValue;
            SkuInstances = skuInstances;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The localized name of the resource. </summary>
        public string LocalizedValue { get; }
        /// <summary> The instances of the resource. </summary>
        public IReadOnlyList<string> SkuInstances { get; }
        /// <summary> The name of the resource. </summary>
        public string Value { get; }
    }
}
