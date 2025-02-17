// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspaceSku : IUtf8JsonSerializable, IJsonModel<OperationalInsightsWorkspaceSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsWorkspaceSku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsWorkspaceSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSku)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            if (CapacityReservationLevel.HasValue)
            {
                writer.WritePropertyName("capacityReservationLevel"u8);
                writer.WriteNumberValue((int)CapacityReservationLevel.Value);
            }
            if (options.Format != "W" && LastSkuUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastSkuUpdate"u8);
                writer.WriteStringValue(LastSkuUpdatedOn.Value, "O");
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

        OperationalInsightsWorkspaceSku IJsonModel<OperationalInsightsWorkspaceSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSku)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsWorkspaceSku(document.RootElement, options);
        }

        internal static OperationalInsightsWorkspaceSku DeserializeOperationalInsightsWorkspaceSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OperationalInsightsWorkspaceSkuName name = default;
            OperationalInsightsWorkspaceCapacityReservationLevel? capacityReservationLevel = default;
            DateTimeOffset? lastSkuUpdate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = new OperationalInsightsWorkspaceSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacityReservationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityReservationLevel = property.Value.GetInt32().ToOperationalInsightsWorkspaceCapacityReservationLevel();
                    continue;
                }
                if (property.NameEquals("lastSkuUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSkuUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsWorkspaceSku(name, capacityReservationLevel, lastSkuUpdate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsWorkspaceSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSku)} does not support '{options.Format}' format.");
            }
        }

        OperationalInsightsWorkspaceSku IPersistableModel<OperationalInsightsWorkspaceSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsWorkspaceSku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSku)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsWorkspaceSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
