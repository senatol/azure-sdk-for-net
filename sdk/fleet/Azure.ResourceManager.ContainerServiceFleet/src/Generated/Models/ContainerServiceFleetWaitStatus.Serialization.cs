// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    public partial class ContainerServiceFleetWaitStatus : IUtf8JsonSerializable, IJsonModel<ContainerServiceFleetWaitStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceFleetWaitStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceFleetWaitStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetWaitStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetWaitStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (options.Format != "W" && WaitDurationInSeconds.HasValue)
            {
                writer.WritePropertyName("waitDurationInSeconds"u8);
                writer.WriteNumberValue(WaitDurationInSeconds.Value);
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

        ContainerServiceFleetWaitStatus IJsonModel<ContainerServiceFleetWaitStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetWaitStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetWaitStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceFleetWaitStatus(document.RootElement, options);
        }

        internal static ContainerServiceFleetWaitStatus DeserializeContainerServiceFleetWaitStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerServiceFleetUpdateStatus status = default;
            int? waitDurationInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ContainerServiceFleetUpdateStatus.DeserializeContainerServiceFleetUpdateStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("waitDurationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    waitDurationInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceFleetWaitStatus(status, waitDurationInSeconds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceFleetWaitStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetWaitStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetWaitStatus)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceFleetWaitStatus IPersistableModel<ContainerServiceFleetWaitStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetWaitStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceFleetWaitStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetWaitStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceFleetWaitStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
