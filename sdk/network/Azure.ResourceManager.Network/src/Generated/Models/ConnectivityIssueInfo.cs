// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information about an issue encountered in the process of checking for connectivity. </summary>
    public partial class ConnectivityIssueInfo
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

        /// <summary> Initializes a new instance of <see cref="ConnectivityIssueInfo"/>. </summary>
        internal ConnectivityIssueInfo()
        {
            Contexts = new ChangeTrackingList<IDictionary<string, string>>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityIssueInfo"/>. </summary>
        /// <param name="origin"> The origin of the issue. </param>
        /// <param name="severity"> The severity of the issue. </param>
        /// <param name="connectivityIssueType"> The type of issue. </param>
        /// <param name="contexts"> Provides additional context on the issue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityIssueInfo(IssueOrigin? origin, IssueSeverity? severity, ConnectivityIssueType? connectivityIssueType, IReadOnlyList<IDictionary<string, string>> contexts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Origin = origin;
            Severity = severity;
            ConnectivityIssueType = connectivityIssueType;
            Contexts = contexts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The origin of the issue. </summary>
        public IssueOrigin? Origin { get; }
        /// <summary> The severity of the issue. </summary>
        public IssueSeverity? Severity { get; }
        /// <summary> The type of issue. </summary>
        public ConnectivityIssueType? ConnectivityIssueType { get; }
        /// <summary> Provides additional context on the issue. </summary>
        public IReadOnlyList<IDictionary<string, string>> Contexts { get; }
    }
}
