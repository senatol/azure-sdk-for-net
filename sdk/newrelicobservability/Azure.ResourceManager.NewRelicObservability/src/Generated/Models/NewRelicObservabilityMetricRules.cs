// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
    public partial class NewRelicObservabilityMetricRules
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

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityMetricRules"/>. </summary>
        public NewRelicObservabilityMetricRules()
        {
            FilteringTags = new ChangeTrackingList<NewRelicObservabilityFilteringTag>();
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityMetricRules"/>. </summary>
        /// <param name="sendMetrics"> Flag specifying if metrics should be sent for the Monitor resource. </param>
        /// <param name="filteringTags"> List of filtering tags to be used for capturing metrics. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityMetricRules(NewRelicObservabilitySendMetricsStatus? sendMetrics, IList<NewRelicObservabilityFilteringTag> filteringTags, string userEmail, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SendMetrics = sendMetrics;
            FilteringTags = filteringTags;
            UserEmail = userEmail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Flag specifying if metrics should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendMetricsStatus? SendMetrics { get; set; }
        /// <summary> List of filtering tags to be used for capturing metrics. </summary>
        public IList<NewRelicObservabilityFilteringTag> FilteringTags { get; }
        /// <summary> User Email. </summary>
        public string UserEmail { get; set; }
    }
}
