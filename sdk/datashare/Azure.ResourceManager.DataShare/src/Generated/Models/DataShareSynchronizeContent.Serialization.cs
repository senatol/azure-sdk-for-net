// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class DataShareSynchronizeContent : IUtf8JsonSerializable, IJsonModel<DataShareSynchronizeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataShareSynchronizeContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataShareSynchronizeContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareSynchronizeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataShareSynchronizeContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SynchronizationMode.HasValue)
            {
                writer.WritePropertyName("synchronizationMode"u8);
                writer.WriteStringValue(SynchronizationMode.Value.ToString());
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

        DataShareSynchronizeContent IJsonModel<DataShareSynchronizeContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareSynchronizeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataShareSynchronizeContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataShareSynchronizeContent(document.RootElement, options);
        }

        internal static DataShareSynchronizeContent DeserializeDataShareSynchronizeContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynchronizationMode? synchronizationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("synchronizationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    synchronizationMode = new SynchronizationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataShareSynchronizeContent(synchronizationMode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataShareSynchronizeContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareSynchronizeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataShareSynchronizeContent)} does not support '{options.Format}' format.");
            }
        }

        DataShareSynchronizeContent IPersistableModel<DataShareSynchronizeContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareSynchronizeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataShareSynchronizeContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataShareSynchronizeContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataShareSynchronizeContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
