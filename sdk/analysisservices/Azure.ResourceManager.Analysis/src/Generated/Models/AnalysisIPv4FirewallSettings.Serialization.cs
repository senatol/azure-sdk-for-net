// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    public partial class AnalysisIPv4FirewallSettings : IUtf8JsonSerializable, IJsonModel<AnalysisIPv4FirewallSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalysisIPv4FirewallSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalysisIPv4FirewallSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisIPv4FirewallSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(FirewallRules is ChangeTrackingList<AnalysisIPv4FirewallRule> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("firewallRules"u8);
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsPowerBIServiceEnabled.HasValue)
            {
                writer.WritePropertyName("enablePowerBIService"u8);
                writer.WriteBooleanValue(IsPowerBIServiceEnabled.Value);
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

        AnalysisIPv4FirewallSettings IJsonModel<AnalysisIPv4FirewallSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisIPv4FirewallSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalysisIPv4FirewallSettings(document.RootElement, options);
        }

        internal static AnalysisIPv4FirewallSettings DeserializeAnalysisIPv4FirewallSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AnalysisIPv4FirewallRule> firewallRules = default;
            bool? enablePowerBIService = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firewallRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnalysisIPv4FirewallRule> array = new List<AnalysisIPv4FirewallRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalysisIPv4FirewallRule.DeserializeAnalysisIPv4FirewallRule(item, options));
                    }
                    firewallRules = array;
                    continue;
                }
                if (property.NameEquals("enablePowerBIService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePowerBIService = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalysisIPv4FirewallSettings(firewallRules ?? new ChangeTrackingList<AnalysisIPv4FirewallRule>(), enablePowerBIService, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalysisIPv4FirewallSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalysisIPv4FirewallSettings)} does not support '{options.Format}' format.");
            }
        }

        AnalysisIPv4FirewallSettings IPersistableModel<AnalysisIPv4FirewallSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisIPv4FirewallSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalysisIPv4FirewallSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalysisIPv4FirewallSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalysisIPv4FirewallSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
