// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    internal partial class MySqlFlexibleServerListResult : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<MySqlFlexibleServerData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        MySqlFlexibleServerListResult IJsonModel<MySqlFlexibleServerListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerListResult(document.RootElement, options);
        }

        internal static MySqlFlexibleServerListResult DeserializeMySqlFlexibleServerListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MySqlFlexibleServerData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerData> array = new List<MySqlFlexibleServerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerData.DeserializeMySqlFlexibleServerData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerListResult(value ?? new ChangeTrackingList<MySqlFlexibleServerData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerListResult)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerListResult IPersistableModel<MySqlFlexibleServerListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
