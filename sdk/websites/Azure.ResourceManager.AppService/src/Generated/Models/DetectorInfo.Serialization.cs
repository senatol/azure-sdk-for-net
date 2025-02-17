// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DetectorInfo : IUtf8JsonSerializable, IJsonModel<DetectorInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DetectorInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DetectorInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectorInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Author != null)
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (options.Format != "W" && Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (options.Format != "W" && !(SupportTopicList is ChangeTrackingList<DetectorSupportTopic> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportTopicList"u8);
                writer.WriteStartArray();
                foreach (var item in SupportTopicList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(AnalysisType is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("analysisType"u8);
                writer.WriteStartArray();
                foreach (var item in AnalysisType)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && DetectorType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(DetectorType.Value.ToSerialString());
            }
            if (options.Format != "W" && Score.HasValue)
            {
                writer.WritePropertyName("score"u8);
                writer.WriteNumberValue(Score.Value);
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

        DetectorInfo IJsonModel<DetectorInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectorInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectorInfo(document.RootElement, options);
        }

        internal static DetectorInfo DeserializeDetectorInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            string description = default;
            string author = default;
            string category = default;
            IReadOnlyList<DetectorSupportTopic> supportTopicList = default;
            IReadOnlyList<string> analysisType = default;
            DetectorType? type = default;
            float? score = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("author"u8))
                {
                    author = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportTopicList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DetectorSupportTopic> array = new List<DetectorSupportTopic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DetectorSupportTopic.DeserializeDetectorSupportTopic(item, options));
                    }
                    supportTopicList = array;
                    continue;
                }
                if (property.NameEquals("analysisType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    analysisType = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToDetectorType();
                    continue;
                }
                if (property.NameEquals("score"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    score = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DetectorInfo(
                id,
                name,
                description,
                author,
                category,
                supportTopicList ?? new ChangeTrackingList<DetectorSupportTopic>(),
                analysisType ?? new ChangeTrackingList<string>(),
                type,
                score,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DetectorInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DetectorInfo)} does not support '{options.Format}' format.");
            }
        }

        DetectorInfo IPersistableModel<DetectorInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDetectorInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DetectorInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DetectorInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
