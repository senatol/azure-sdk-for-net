// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobError : IUtf8JsonSerializable, IJsonModel<MediaJobError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaJobError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Code.HasValue)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code.Value.ToString());
            }
            if (options.Format != "W" && Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Category.HasValue)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (options.Format != "W" && Retry.HasValue)
            {
                writer.WritePropertyName("retry"u8);
                writer.WriteStringValue(Retry.Value.ToString());
            }
            if (options.Format != "W" && !(Details is ChangeTrackingList<MediaJobErrorDetail> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        MediaJobError IJsonModel<MediaJobError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobError(document.RootElement, options);
        }

        internal static MediaJobError DeserializeMediaJobError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MediaJobErrorCode? code = default;
            string message = default;
            MediaJobErrorCategory? category = default;
            MediaJobRetry? retry = default;
            IReadOnlyList<MediaJobErrorDetail> details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = new MediaJobErrorCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MediaJobErrorCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retry = new MediaJobRetry(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobErrorDetail> array = new List<MediaJobErrorDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobErrorDetail.DeserializeMediaJobErrorDetail(item, options));
                    }
                    details = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaJobError(
                code,
                message,
                category,
                retry,
                details ?? new ChangeTrackingList<MediaJobErrorDetail>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaJobError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaJobError)} does not support '{options.Format}' format.");
            }
        }

        MediaJobError IPersistableModel<MediaJobError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaJobError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaJobError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaJobError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
