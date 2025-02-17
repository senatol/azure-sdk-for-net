// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the test job. </summary>
    public partial class RunbookTestJob
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

        /// <summary> Initializes a new instance of <see cref="RunbookTestJob"/>. </summary>
        internal RunbookTestJob()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="RunbookTestJob"/>. </summary>
        /// <param name="createdOn"> Gets or sets the creation time of the test job. </param>
        /// <param name="status"> Gets or sets the status of the test job. </param>
        /// <param name="statusDetails"> Gets or sets the status details of the test job. </param>
        /// <param name="runOn"> Gets or sets the runOn which specifies the group name where the job is to be executed. </param>
        /// <param name="startOn"> Gets or sets the start time of the test job. </param>
        /// <param name="endOn"> Gets or sets the end time of the test job. </param>
        /// <param name="exception"> Gets or sets the exception of the test job. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time of the test job. </param>
        /// <param name="lastStatusModifiedOn"> Gets or sets the last status modified time of the test job. </param>
        /// <param name="parameters"> Gets or sets the parameters of the test job. </param>
        /// <param name="logActivityTrace"> The activity-level tracing options of the runbook. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunbookTestJob(DateTimeOffset? createdOn, string status, string statusDetails, string runOn, DateTimeOffset? startOn, DateTimeOffset? endOn, string exception, DateTimeOffset? lastModifiedOn, DateTimeOffset? lastStatusModifiedOn, IReadOnlyDictionary<string, string> parameters, int? logActivityTrace, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CreatedOn = createdOn;
            Status = status;
            StatusDetails = statusDetails;
            RunOn = runOn;
            StartOn = startOn;
            EndOn = endOn;
            Exception = exception;
            LastModifiedOn = lastModifiedOn;
            LastStatusModifiedOn = lastStatusModifiedOn;
            Parameters = parameters;
            LogActivityTrace = logActivityTrace;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the creation time of the test job. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets or sets the status of the test job. </summary>
        public string Status { get; }
        /// <summary> Gets or sets the status details of the test job. </summary>
        public string StatusDetails { get; }
        /// <summary> Gets or sets the runOn which specifies the group name where the job is to be executed. </summary>
        public string RunOn { get; }
        /// <summary> Gets or sets the start time of the test job. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets or sets the end time of the test job. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Gets or sets the exception of the test job. </summary>
        public string Exception { get; }
        /// <summary> Gets or sets the last modified time of the test job. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets or sets the last status modified time of the test job. </summary>
        public DateTimeOffset? LastStatusModifiedOn { get; }
        /// <summary> Gets or sets the parameters of the test job. </summary>
        public IReadOnlyDictionary<string, string> Parameters { get; }
        /// <summary> The activity-level tracing options of the runbook. </summary>
        public int? LogActivityTrace { get; }
    }
}
