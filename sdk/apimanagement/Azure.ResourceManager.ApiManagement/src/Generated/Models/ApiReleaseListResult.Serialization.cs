// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ApiReleaseListResult : IUtf8JsonSerializable, IJsonModel<ApiReleaseListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiReleaseListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiReleaseListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiReleaseListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiReleaseListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(Value is ChangeTrackingList<ApiReleaseData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Count.HasValue)
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (options.Format != "W" && NextLink != null)
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

        ApiReleaseListResult IJsonModel<ApiReleaseListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiReleaseListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiReleaseListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiReleaseListResult(document.RootElement, options);
        }

        internal static ApiReleaseListResult DeserializeApiReleaseListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ApiReleaseData> value = default;
            long? count = default;
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
                    List<ApiReleaseData> array = new List<ApiReleaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiReleaseData.DeserializeApiReleaseData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
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
            return new ApiReleaseListResult(value ?? new ChangeTrackingList<ApiReleaseData>(), count, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiReleaseListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiReleaseListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiReleaseListResult)} does not support '{options.Format}' format.");
            }
        }

        ApiReleaseListResult IPersistableModel<ApiReleaseListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiReleaseListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiReleaseListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiReleaseListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiReleaseListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
