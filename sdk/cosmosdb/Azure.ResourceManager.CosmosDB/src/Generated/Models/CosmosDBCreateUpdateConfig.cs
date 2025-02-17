// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are "If-Match", "If-None-Match", "Session-Token" and "Throughput". </summary>
    public partial class CosmosDBCreateUpdateConfig
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBCreateUpdateConfig"/>. </summary>
        public CosmosDBCreateUpdateConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBCreateUpdateConfig"/>. </summary>
        /// <param name="throughput"> Request Units per second. For example, "throughput": 10000. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. Note: Either throughput or autoscaleSettings is required, but not both. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBCreateUpdateConfig(int? throughput, AutoscaleSettings autoscaleSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Throughput = throughput;
            AutoscaleSettings = autoscaleSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Request Units per second. For example, "throughput": 10000. </summary>
        public int? Throughput { get; set; }
        /// <summary> Specifies the Autoscale settings. Note: Either throughput or autoscaleSettings is required, but not both. </summary>
        internal AutoscaleSettings AutoscaleSettings { get; set; }
        /// <summary> Represents maximum throughput, the resource can scale up to. </summary>
        public int? AutoscaleMaxThroughput
        {
            get => AutoscaleSettings is null ? default : AutoscaleSettings.MaxThroughput;
            set
            {
                if (AutoscaleSettings is null)
                    AutoscaleSettings = new AutoscaleSettings();
                AutoscaleSettings.MaxThroughput = value;
            }
        }
    }
}
