// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceProviderCapabilities. </summary>
    public partial class ResourceProviderCapabilities
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

        /// <summary> Initializes a new instance of <see cref="ResourceProviderCapabilities"/>. </summary>
        /// <param name="quotaId"></param>
        /// <param name="effect"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaId"/> is null. </exception>
        public ResourceProviderCapabilities(string quotaId, ResourceProviderCapabilitiesEffect effect)
        {
            if (quotaId == null)
            {
                throw new ArgumentNullException(nameof(quotaId));
            }

            QuotaId = quotaId;
            Effect = effect;
            RequiredFeatures = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceProviderCapabilities"/>. </summary>
        /// <param name="quotaId"></param>
        /// <param name="effect"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceProviderCapabilities(string quotaId, ResourceProviderCapabilitiesEffect effect, IList<string> requiredFeatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QuotaId = quotaId;
            Effect = effect;
            RequiredFeatures = requiredFeatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceProviderCapabilities"/> for deserialization. </summary>
        internal ResourceProviderCapabilities()
        {
        }

        /// <summary> Gets or sets the quota id. </summary>
        public string QuotaId { get; set; }
        /// <summary> Gets or sets the effect. </summary>
        public ResourceProviderCapabilitiesEffect Effect { get; set; }
        /// <summary> Gets the required features. </summary>
        public IList<string> RequiredFeatures { get; }
    }
}
