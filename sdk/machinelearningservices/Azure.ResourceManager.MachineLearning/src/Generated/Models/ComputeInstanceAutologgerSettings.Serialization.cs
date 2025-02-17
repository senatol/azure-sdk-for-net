// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ComputeInstanceAutologgerSettings : IUtf8JsonSerializable, IJsonModel<ComputeInstanceAutologgerSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeInstanceAutologgerSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputeInstanceAutologgerSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeInstanceAutologgerSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeInstanceAutologgerSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MlflowAutologger.HasValue)
            {
                writer.WritePropertyName("mlflowAutologger"u8);
                writer.WriteStringValue(MlflowAutologger.Value.ToString());
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

        ComputeInstanceAutologgerSettings IJsonModel<ComputeInstanceAutologgerSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeInstanceAutologgerSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeInstanceAutologgerSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeInstanceAutologgerSettings(document.RootElement, options);
        }

        internal static ComputeInstanceAutologgerSettings DeserializeComputeInstanceAutologgerSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningFlowAutoLogger? mlflowAutologger = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mlflowAutologger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mlflowAutologger = new MachineLearningFlowAutoLogger(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputeInstanceAutologgerSettings(mlflowAutologger, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeInstanceAutologgerSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeInstanceAutologgerSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeInstanceAutologgerSettings)} does not support '{options.Format}' format.");
            }
        }

        ComputeInstanceAutologgerSettings IPersistableModel<ComputeInstanceAutologgerSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeInstanceAutologgerSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeInstanceAutologgerSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeInstanceAutologgerSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeInstanceAutologgerSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
