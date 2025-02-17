// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessRequestInfo : IUtf8JsonSerializable, IJsonModel<JitNetworkAccessRequestInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JitNetworkAccessRequestInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JitNetworkAccessRequestInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessRequestInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("virtualMachines"u8);
            writer.WriteStartArray();
            foreach (var item in VirtualMachines)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("startTimeUtc"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("requestor"u8);
            writer.WriteStringValue(Requestor);
            if (Justification != null)
            {
                writer.WritePropertyName("justification"u8);
                writer.WriteStringValue(Justification);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        JitNetworkAccessRequestInfo IJsonModel<JitNetworkAccessRequestInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessRequestInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessRequestInfo(document.RootElement, options);
        }

        internal static JitNetworkAccessRequestInfo DeserializeJitNetworkAccessRequestInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<JitNetworkAccessRequestVirtualMachine> virtualMachines = default;
            DateTimeOffset startTimeUtc = default;
            string requestor = default;
            string justification = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachines"u8))
                {
                    List<JitNetworkAccessRequestVirtualMachine> array = new List<JitNetworkAccessRequestVirtualMachine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JitNetworkAccessRequestVirtualMachine.DeserializeJitNetworkAccessRequestVirtualMachine(item, options));
                    }
                    virtualMachines = array;
                    continue;
                }
                if (property.NameEquals("startTimeUtc"u8))
                {
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("requestor"u8))
                {
                    requestor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justification"u8))
                {
                    justification = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JitNetworkAccessRequestInfo(virtualMachines, startTimeUtc, requestor, justification, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JitNetworkAccessRequestInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessRequestInfo)} does not support '{options.Format}' format.");
            }
        }

        JitNetworkAccessRequestInfo IPersistableModel<JitNetworkAccessRequestInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJitNetworkAccessRequestInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessRequestInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JitNetworkAccessRequestInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
