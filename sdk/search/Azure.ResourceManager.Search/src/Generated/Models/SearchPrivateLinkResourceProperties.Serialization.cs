// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    public partial class SearchPrivateLinkResourceProperties : IUtf8JsonSerializable, IJsonModel<SearchPrivateLinkResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchPrivateLinkResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchPrivateLinkResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchPrivateLinkResourceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && GroupId != null)
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (options.Format != "W" && !(RequiredMembers is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("requiredMembers"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredMembers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(RequiredZoneNames is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("requiredZoneNames"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredZoneNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(ShareablePrivateLinkResourceTypes is ChangeTrackingList<ShareableSearchServicePrivateLinkResourceType> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("shareablePrivateLinkResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ShareablePrivateLinkResourceTypes)
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

        SearchPrivateLinkResourceProperties IJsonModel<SearchPrivateLinkResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchPrivateLinkResourceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchPrivateLinkResourceProperties(document.RootElement, options);
        }

        internal static SearchPrivateLinkResourceProperties DeserializeSearchPrivateLinkResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string groupId = default;
            IReadOnlyList<string> requiredMembers = default;
            IReadOnlyList<string> requiredZoneNames = default;
            IReadOnlyList<ShareableSearchServicePrivateLinkResourceType> shareablePrivateLinkResourceTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredMembers"u8))
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
                    requiredMembers = array;
                    continue;
                }
                if (property.NameEquals("requiredZoneNames"u8))
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
                    requiredZoneNames = array;
                    continue;
                }
                if (property.NameEquals("shareablePrivateLinkResourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ShareableSearchServicePrivateLinkResourceType> array = new List<ShareableSearchServicePrivateLinkResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShareableSearchServicePrivateLinkResourceType.DeserializeShareableSearchServicePrivateLinkResourceType(item, options));
                    }
                    shareablePrivateLinkResourceTypes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchPrivateLinkResourceProperties(groupId, requiredMembers ?? new ChangeTrackingList<string>(), requiredZoneNames ?? new ChangeTrackingList<string>(), shareablePrivateLinkResourceTypes ?? new ChangeTrackingList<ShareableSearchServicePrivateLinkResourceType>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchPrivateLinkResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SearchPrivateLinkResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        SearchPrivateLinkResourceProperties IPersistableModel<SearchPrivateLinkResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchPrivateLinkResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchPrivateLinkResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SearchPrivateLinkResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchPrivateLinkResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
