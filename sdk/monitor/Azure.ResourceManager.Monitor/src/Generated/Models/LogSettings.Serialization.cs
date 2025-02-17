// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class LogSettings : IUtf8JsonSerializable, IJsonModel<LogSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (CategoryGroup != null)
            {
                writer.WritePropertyName("categoryGroup"u8);
                writer.WriteStringValue(CategoryGroup);
            }
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (RetentionPolicy != null)
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy);
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

        LogSettings IJsonModel<LogSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogSettings(document.RootElement, options);
        }

        internal static LogSettings DeserializeLogSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string category = default;
            string categoryGroup = default;
            bool enabled = default;
            RetentionPolicy retentionPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categoryGroup"u8))
                {
                    categoryGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPolicy = RetentionPolicy.DeserializeRetentionPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogSettings(category, categoryGroup, enabled, retentionPolicy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogSettings)} does not support '{options.Format}' format.");
            }
        }

        LogSettings IPersistableModel<LogSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
