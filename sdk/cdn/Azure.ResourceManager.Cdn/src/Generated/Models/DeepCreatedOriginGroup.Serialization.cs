// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeepCreatedOriginGroup : IUtf8JsonSerializable, IJsonModel<DeepCreatedOriginGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeepCreatedOriginGroup>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeepCreatedOriginGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeepCreatedOriginGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeepCreatedOriginGroup)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (HealthProbeSettings != null)
            {
                if (HealthProbeSettings != null)
                {
                    writer.WritePropertyName("healthProbeSettings"u8);
                    writer.WriteObjectValue(HealthProbeSettings);
                }
                else
                {
                    writer.WriteNull("healthProbeSettings");
                }
            }
            if (!(Origins is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes.HasValue)
            {
                if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8);
                    writer.WriteNumberValue(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (ResponseBasedOriginErrorDetectionSettings != null)
            {
                if (ResponseBasedOriginErrorDetectionSettings != null)
                {
                    writer.WritePropertyName("responseBasedOriginErrorDetectionSettings"u8);
                    writer.WriteObjectValue(ResponseBasedOriginErrorDetectionSettings);
                }
                else
                {
                    writer.WriteNull("responseBasedOriginErrorDetectionSettings");
                }
            }
            writer.WriteEndObject();
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

        DeepCreatedOriginGroup IJsonModel<DeepCreatedOriginGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeepCreatedOriginGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeepCreatedOriginGroup)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeepCreatedOriginGroup(document.RootElement, options);
        }

        internal static DeepCreatedOriginGroup DeserializeDeepCreatedOriginGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            HealthProbeSettings healthProbeSettings = default;
            IList<WritableSubResource> origins = default;
            int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default;
            ResponseBasedOriginErrorDetectionSettings responseBasedOriginErrorDetectionSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("healthProbeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                healthProbeSettings = null;
                                continue;
                            }
                            healthProbeSettings = HealthProbeSettings.DeserializeHealthProbeSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("origins"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            origins = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficRestorationTimeToHealedOrNewEndpointsInMinutes = null;
                                continue;
                            }
                            trafficRestorationTimeToHealedOrNewEndpointsInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("responseBasedOriginErrorDetectionSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                responseBasedOriginErrorDetectionSettings = null;
                                continue;
                            }
                            responseBasedOriginErrorDetectionSettings = ResponseBasedOriginErrorDetectionSettings.DeserializeResponseBasedOriginErrorDetectionSettings(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeepCreatedOriginGroup(
                name,
                healthProbeSettings,
                origins ?? new ChangeTrackingList<WritableSubResource>(),
                trafficRestorationTimeToHealedOrNewEndpointsInMinutes,
                responseBasedOriginErrorDetectionSettings,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeepCreatedOriginGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeepCreatedOriginGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeepCreatedOriginGroup)} does not support '{options.Format}' format.");
            }
        }

        DeepCreatedOriginGroup IPersistableModel<DeepCreatedOriginGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeepCreatedOriginGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeepCreatedOriginGroup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeepCreatedOriginGroup)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeepCreatedOriginGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
