// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class OSProfileUpdateWindowsConfiguration : IUtf8JsonSerializable, IJsonModel<OSProfileUpdateWindowsConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OSProfileUpdateWindowsConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OSProfileUpdateWindowsConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileUpdateWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSProfileUpdateWindowsConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ProvisionVmAgent.HasValue)
            {
                writer.WritePropertyName("provisionVMAgent"u8);
                writer.WriteBooleanValue(ProvisionVmAgent.Value);
            }
            if (ProvisionVmConfigAgent.HasValue)
            {
                writer.WritePropertyName("provisionVMConfigAgent"u8);
                writer.WriteBooleanValue(ProvisionVmConfigAgent.Value);
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

        OSProfileUpdateWindowsConfiguration IJsonModel<OSProfileUpdateWindowsConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileUpdateWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSProfileUpdateWindowsConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOSProfileUpdateWindowsConfiguration(document.RootElement, options);
        }

        internal static OSProfileUpdateWindowsConfiguration DeserializeOSProfileUpdateWindowsConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? provisionVmAgent = default;
            bool? provisionVmConfigAgent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisionVMAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionVmAgent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provisionVMConfigAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionVmConfigAgent = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OSProfileUpdateWindowsConfiguration(provisionVmAgent, provisionVmConfigAgent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OSProfileUpdateWindowsConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileUpdateWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OSProfileUpdateWindowsConfiguration)} does not support '{options.Format}' format.");
            }
        }

        OSProfileUpdateWindowsConfiguration IPersistableModel<OSProfileUpdateWindowsConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileUpdateWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOSProfileUpdateWindowsConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OSProfileUpdateWindowsConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OSProfileUpdateWindowsConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
