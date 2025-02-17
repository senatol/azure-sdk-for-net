// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class CreateCallRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targets"u8);
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (SourceCallerIdNumber != null)
            {
                writer.WritePropertyName("sourceCallerIdNumber"u8);
                writer.WriteObjectValue(SourceCallerIdNumber);
            }
            if (SourceDisplayName != null)
            {
                writer.WritePropertyName("sourceDisplayName"u8);
                writer.WriteStringValue(SourceDisplayName);
            }
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (OperationContext != null)
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            writer.WritePropertyName("callbackUri"u8);
            writer.WriteStringValue(CallbackUri);
            if (MediaStreamingConfiguration != null)
            {
                writer.WritePropertyName("mediaStreamingConfiguration"u8);
                writer.WriteObjectValue(MediaStreamingConfiguration);
            }
            if (TranscriptionConfiguration != null)
            {
                writer.WritePropertyName("transcriptionConfiguration"u8);
                writer.WriteObjectValue(TranscriptionConfiguration);
            }
            if (CallIntelligenceOptions != null)
            {
                writer.WritePropertyName("callIntelligenceOptions"u8);
                writer.WriteObjectValue(CallIntelligenceOptions);
            }
            if (CustomCallingContext != null)
            {
                writer.WritePropertyName("customCallingContext"u8);
                writer.WriteObjectValue(CustomCallingContext);
            }
            writer.WriteEndObject();
        }
    }
}
