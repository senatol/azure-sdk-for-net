// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class StorageProfileSmbCSIDriver : IUtf8JsonSerializable, IJsonModel<StorageProfileSmbCSIDriver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageProfileSmbCSIDriver>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageProfileSmbCSIDriver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfileSmbCSIDriver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageProfileSmbCSIDriver)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsSmbCsiDriverEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsSmbCsiDriverEnabled.Value);
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

        StorageProfileSmbCSIDriver IJsonModel<StorageProfileSmbCSIDriver>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfileSmbCSIDriver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageProfileSmbCSIDriver)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageProfileSmbCSIDriver(document.RootElement, options);
        }

        internal static StorageProfileSmbCSIDriver DeserializeStorageProfileSmbCSIDriver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageProfileSmbCSIDriver(enabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageProfileSmbCSIDriver>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfileSmbCSIDriver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageProfileSmbCSIDriver)} does not support '{options.Format}' format.");
            }
        }

        StorageProfileSmbCSIDriver IPersistableModel<StorageProfileSmbCSIDriver>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageProfileSmbCSIDriver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageProfileSmbCSIDriver(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageProfileSmbCSIDriver)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageProfileSmbCSIDriver>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
