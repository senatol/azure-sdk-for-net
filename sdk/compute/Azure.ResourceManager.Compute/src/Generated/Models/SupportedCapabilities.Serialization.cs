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
    public partial class SupportedCapabilities : IUtf8JsonSerializable, IJsonModel<SupportedCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SupportedCapabilities>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SupportedCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportedCapabilities)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DiskControllerTypes != null)
            {
                writer.WritePropertyName("diskControllerTypes"u8);
                writer.WriteStringValue(DiskControllerTypes);
            }
            if (AcceleratedNetwork.HasValue)
            {
                writer.WritePropertyName("acceleratedNetwork"u8);
                writer.WriteBooleanValue(AcceleratedNetwork.Value);
            }
            if (Architecture.HasValue)
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture.Value.ToString());
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

        SupportedCapabilities IJsonModel<SupportedCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportedCapabilities)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportedCapabilities(document.RootElement, options);
        }

        internal static SupportedCapabilities DeserializeSupportedCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskControllerTypes = default;
            bool? acceleratedNetwork = default;
            ArchitectureType? architecture = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskControllerTypes"u8))
                {
                    diskControllerTypes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceleratedNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceleratedNetwork = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    architecture = new ArchitectureType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SupportedCapabilities(diskControllerTypes, acceleratedNetwork, architecture, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SupportedCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SupportedCapabilities)} does not support '{options.Format}' format.");
            }
        }

        SupportedCapabilities IPersistableModel<SupportedCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSupportedCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SupportedCapabilities)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SupportedCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
