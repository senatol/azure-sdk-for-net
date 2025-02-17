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
    public partial class MachineLearningTargetUtilizationScaleSettings : IUtf8JsonSerializable, IJsonModel<MachineLearningTargetUtilizationScaleSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningTargetUtilizationScaleSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningTargetUtilizationScaleSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTargetUtilizationScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTargetUtilizationScaleSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MaxInstances.HasValue)
            {
                writer.WritePropertyName("maxInstances"u8);
                writer.WriteNumberValue(MaxInstances.Value);
            }
            if (MinInstances.HasValue)
            {
                writer.WritePropertyName("minInstances"u8);
                writer.WriteNumberValue(MinInstances.Value);
            }
            if (PollingInterval.HasValue)
            {
                writer.WritePropertyName("pollingInterval"u8);
                writer.WriteStringValue(PollingInterval.Value, "P");
            }
            if (TargetUtilizationPercentage.HasValue)
            {
                writer.WritePropertyName("targetUtilizationPercentage"u8);
                writer.WriteNumberValue(TargetUtilizationPercentage.Value);
            }
            writer.WritePropertyName("scaleType"u8);
            writer.WriteStringValue(ScaleType.ToString());
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

        MachineLearningTargetUtilizationScaleSettings IJsonModel<MachineLearningTargetUtilizationScaleSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTargetUtilizationScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTargetUtilizationScaleSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningTargetUtilizationScaleSettings(document.RootElement, options);
        }

        internal static MachineLearningTargetUtilizationScaleSettings DeserializeMachineLearningTargetUtilizationScaleSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxInstances = default;
            int? minInstances = default;
            TimeSpan? pollingInterval = default;
            int? targetUtilizationPercentage = default;
            ScaleType scaleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxInstances = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minInstances = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pollingInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pollingInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("targetUtilizationPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetUtilizationPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    scaleType = new ScaleType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningTargetUtilizationScaleSettings(
                scaleType,
                serializedAdditionalRawData,
                maxInstances,
                minInstances,
                pollingInterval,
                targetUtilizationPercentage);
        }

        BinaryData IPersistableModel<MachineLearningTargetUtilizationScaleSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTargetUtilizationScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTargetUtilizationScaleSettings)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningTargetUtilizationScaleSettings IPersistableModel<MachineLearningTargetUtilizationScaleSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTargetUtilizationScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningTargetUtilizationScaleSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTargetUtilizationScaleSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningTargetUtilizationScaleSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
