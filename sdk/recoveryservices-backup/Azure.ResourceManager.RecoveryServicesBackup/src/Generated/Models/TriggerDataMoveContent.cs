// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Trigger DataMove Request. </summary>
    public partial class TriggerDataMoveContent
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

        /// <summary> Initializes a new instance of <see cref="TriggerDataMoveContent"/>. </summary>
        /// <param name="sourceResourceId"> ARM Id of source vault. </param>
        /// <param name="sourceRegion"> Source Region. </param>
        /// <param name="dataMoveLevel"> DataMove Level. </param>
        /// <param name="correlationId"> Correlation Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceResourceId"/> or <paramref name="correlationId"/> is null. </exception>
        public TriggerDataMoveContent(ResourceIdentifier sourceResourceId, AzureLocation sourceRegion, DataMoveLevel dataMoveLevel, string correlationId)
        {
            if (sourceResourceId == null)
            {
                throw new ArgumentNullException(nameof(sourceResourceId));
            }
            if (correlationId == null)
            {
                throw new ArgumentNullException(nameof(correlationId));
            }

            SourceResourceId = sourceResourceId;
            SourceRegion = sourceRegion;
            DataMoveLevel = dataMoveLevel;
            CorrelationId = correlationId;
            SourceContainerArmIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="TriggerDataMoveContent"/>. </summary>
        /// <param name="sourceResourceId"> ARM Id of source vault. </param>
        /// <param name="sourceRegion"> Source Region. </param>
        /// <param name="dataMoveLevel"> DataMove Level. </param>
        /// <param name="correlationId"> Correlation Id. </param>
        /// <param name="sourceContainerArmIds"> Source Container ArmIds. </param>
        /// <param name="doesPauseGC"> Pause GC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggerDataMoveContent(ResourceIdentifier sourceResourceId, AzureLocation sourceRegion, DataMoveLevel dataMoveLevel, string correlationId, IList<ResourceIdentifier> sourceContainerArmIds, bool? doesPauseGC, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceResourceId = sourceResourceId;
            SourceRegion = sourceRegion;
            DataMoveLevel = dataMoveLevel;
            CorrelationId = correlationId;
            SourceContainerArmIds = sourceContainerArmIds;
            DoesPauseGC = doesPauseGC;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TriggerDataMoveContent"/> for deserialization. </summary>
        internal TriggerDataMoveContent()
        {
        }

        /// <summary> ARM Id of source vault. </summary>
        public ResourceIdentifier SourceResourceId { get; }
        /// <summary> Source Region. </summary>
        public AzureLocation SourceRegion { get; }
        /// <summary> DataMove Level. </summary>
        public DataMoveLevel DataMoveLevel { get; }
        /// <summary> Correlation Id. </summary>
        public string CorrelationId { get; }
        /// <summary> Source Container ArmIds. </summary>
        public IList<ResourceIdentifier> SourceContainerArmIds { get; }
        /// <summary> Pause GC. </summary>
        public bool? DoesPauseGC { get; set; }
    }
}
