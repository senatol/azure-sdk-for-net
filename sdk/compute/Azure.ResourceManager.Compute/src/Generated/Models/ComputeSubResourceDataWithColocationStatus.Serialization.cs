// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ComputeSubResourceDataWithColocationStatus : IUtf8JsonSerializable, IJsonModel<ComputeSubResourceDataWithColocationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeSubResourceDataWithColocationStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputeSubResourceDataWithColocationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSubResourceDataWithColocationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeSubResourceDataWithColocationStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ColocationStatus != null)
            {
                writer.WritePropertyName("colocationStatus"u8);
                writer.WriteObjectValue(ColocationStatus);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        ComputeSubResourceDataWithColocationStatus IJsonModel<ComputeSubResourceDataWithColocationStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSubResourceDataWithColocationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeSubResourceDataWithColocationStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeSubResourceDataWithColocationStatus(document.RootElement, options);
        }

        internal static ComputeSubResourceDataWithColocationStatus DeserializeComputeSubResourceDataWithColocationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InstanceViewStatus colocationStatus = default;
            ResourceIdentifier id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("colocationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    colocationStatus = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputeSubResourceDataWithColocationStatus(id, serializedAdditionalRawData, colocationStatus);
        }

        BinaryData IPersistableModel<ComputeSubResourceDataWithColocationStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSubResourceDataWithColocationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeSubResourceDataWithColocationStatus)} does not support '{options.Format}' format.");
            }
        }

        ComputeSubResourceDataWithColocationStatus IPersistableModel<ComputeSubResourceDataWithColocationStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSubResourceDataWithColocationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeSubResourceDataWithColocationStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeSubResourceDataWithColocationStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeSubResourceDataWithColocationStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
