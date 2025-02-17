// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    public partial class WorkbookData : IUtf8JsonSerializable, IJsonModel<WorkbookData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkbookData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkbookData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkbookData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Kind.HasValue)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (SerializedData != null)
            {
                if (SerializedData != null)
                {
                    writer.WritePropertyName("serializedData"u8);
                    writer.WriteStringValue(SerializedData);
                }
                else
                {
                    writer.WriteNull("serializedData");
                }
            }
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && ModifiedOn.HasValue)
            {
                writer.WritePropertyName("timeModified"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (options.Format != "W" && UserId != null)
            {
                writer.WritePropertyName("userId"u8);
                writer.WriteStringValue(UserId);
            }
            if (SourceId != null)
            {
                writer.WritePropertyName("sourceId"u8);
                writer.WriteStringValue(SourceId);
            }
            if (StorageUri != null)
            {
                if (StorageUri != null)
                {
                    writer.WritePropertyName("storageUri"u8);
                    writer.WriteStringValue(StorageUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("storageUri");
                }
            }
            if (Description != null)
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (options.Format != "W" && Revision != null)
            {
                if (Revision != null)
                {
                    writer.WritePropertyName("revision"u8);
                    writer.WriteStringValue(Revision);
                }
                else
                {
                    writer.WriteNull("revision");
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

        WorkbookData IJsonModel<WorkbookData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkbookData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkbookData(document.RootElement, options);
        }

        internal static WorkbookData DeserializeWorkbookData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            WorkbookSharedTypeKind? kind = default;
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            string serializedData = default;
            string version = default;
            DateTimeOffset? timeModified = default;
            string category = default;
            string userId = default;
            string sourceId = default;
            Uri storageUri = default;
            string description = default;
            string revision = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new WorkbookSharedTypeKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serializedData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                serializedData = null;
                                continue;
                            }
                            serializedData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("category"u8))
                        {
                            category = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userId"u8))
                        {
                            userId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceId"u8))
                        {
                            sourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                storageUri = null;
                                continue;
                            }
                            storageUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                description = null;
                                continue;
                            }
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("revision"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                revision = null;
                                continue;
                            }
                            revision = property0.Value.GetString();
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
            return new WorkbookData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                displayName,
                serializedData,
                version,
                timeModified,
                category,
                userId,
                sourceId,
                storageUri,
                description,
                revision,
                identity,
                kind,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkbookData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkbookData)} does not support '{options.Format}' format.");
            }
        }

        WorkbookData IPersistableModel<WorkbookData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkbookData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkbookData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkbookData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkbookData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
