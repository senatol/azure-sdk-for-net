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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationWatcherData : IUtf8JsonSerializable, IJsonModel<AutomationWatcherData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationWatcherData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationWatcherData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWatcherData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationWatcherData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (ExecutionFrequencyInSeconds.HasValue)
            {
                writer.WritePropertyName("executionFrequencyInSeconds"u8);
                writer.WriteNumberValue(ExecutionFrequencyInSeconds.Value);
            }
            if (ScriptName != null)
            {
                writer.WritePropertyName("scriptName"u8);
                writer.WriteStringValue(ScriptName);
            }
            if (!(ScriptParameters is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("scriptParameters"u8);
                writer.WriteStartObject();
                foreach (var item in ScriptParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ScriptRunOn != null)
            {
                writer.WritePropertyName("scriptRunOn"u8);
                writer.WriteStringValue(ScriptRunOn);
            }
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && LastModifiedBy != null)
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteStringValue(LastModifiedBy);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        AutomationWatcherData IJsonModel<AutomationWatcherData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWatcherData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationWatcherData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationWatcherData(document.RootElement, options);
        }

        internal static AutomationWatcherData DeserializeAutomationWatcherData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            long? executionFrequencyInSeconds = default;
            string scriptName = default;
            IDictionary<string, string> scriptParameters = default;
            string scriptRunOn = default;
            string status = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? lastModifiedTime = default;
            string lastModifiedBy = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("executionFrequencyInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executionFrequencyInSeconds = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("scriptName"u8))
                        {
                            scriptName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scriptParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            scriptParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("scriptRunOn"u8))
                        {
                            scriptRunOn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
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
            return new AutomationWatcherData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                etag,
                executionFrequencyInSeconds,
                scriptName,
                scriptParameters ?? new ChangeTrackingDictionary<string, string>(),
                scriptRunOn,
                status,
                creationTime,
                lastModifiedTime,
                lastModifiedBy,
                description,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationWatcherData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWatcherData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationWatcherData)} does not support '{options.Format}' format.");
            }
        }

        AutomationWatcherData IPersistableModel<AutomationWatcherData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationWatcherData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationWatcherData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationWatcherData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationWatcherData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
