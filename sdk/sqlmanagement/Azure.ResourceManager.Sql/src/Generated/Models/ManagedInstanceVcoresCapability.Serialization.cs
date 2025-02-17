// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceVcoresCapability : IUtf8JsonSerializable, IJsonModel<ManagedInstanceVcoresCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceVcoresCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceVcoresCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Value.HasValue)
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (options.Format != "W" && IncludedMaxSize != null)
            {
                writer.WritePropertyName("includedMaxSize"u8);
                writer.WriteObjectValue(IncludedMaxSize);
            }
            if (options.Format != "W" && !(SupportedStorageSizes is ChangeTrackingList<MaxSizeRangeCapability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedStorageSizes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedStorageSizes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && IsInstancePoolSupported.HasValue)
            {
                writer.WritePropertyName("instancePoolSupported"u8);
                writer.WriteBooleanValue(IsInstancePoolSupported.Value);
            }
            if (options.Format != "W" && IsStandaloneSupported.HasValue)
            {
                writer.WritePropertyName("standaloneSupported"u8);
                writer.WriteBooleanValue(IsStandaloneSupported.Value);
            }
            if (options.Format != "W" && !(SupportedMaintenanceConfigurations is ChangeTrackingList<ManagedInstanceMaintenanceConfigurationCapability> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("supportedMaintenanceConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedMaintenanceConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Reason != null)
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        ManagedInstanceVcoresCapability IJsonModel<ManagedInstanceVcoresCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceVcoresCapability(document.RootElement, options);
        }

        internal static ManagedInstanceVcoresCapability DeserializeManagedInstanceVcoresCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int? value = default;
            MaxSizeCapability includedMaxSize = default;
            IReadOnlyList<MaxSizeRangeCapability> supportedStorageSizes = default;
            bool? instancePoolSupported = default;
            bool? standaloneSupported = default;
            IReadOnlyList<ManagedInstanceMaintenanceConfigurationCapability> supportedMaintenanceConfigurations = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("includedMaxSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportedStorageSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item, options));
                    }
                    supportedStorageSizes = array;
                    continue;
                }
                if (property.NameEquals("instancePoolSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instancePoolSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("standaloneSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standaloneSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedMaintenanceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceMaintenanceConfigurationCapability> array = new List<ManagedInstanceMaintenanceConfigurationCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceMaintenanceConfigurationCapability.DeserializeManagedInstanceMaintenanceConfigurationCapability(item, options));
                    }
                    supportedMaintenanceConfigurations = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceVcoresCapability(
                name,
                value,
                includedMaxSize,
                supportedStorageSizes ?? new ChangeTrackingList<MaxSizeRangeCapability>(),
                instancePoolSupported,
                standaloneSupported,
                supportedMaintenanceConfigurations ?? new ChangeTrackingList<ManagedInstanceMaintenanceConfigurationCapability>(),
                status,
                reason,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedInstanceVcoresCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support '{options.Format}' format.");
            }
        }

        ManagedInstanceVcoresCapability IPersistableModel<ManagedInstanceVcoresCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceVcoresCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceVcoresCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceVcoresCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceVcoresCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
