// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class Kustomization : IUtf8JsonSerializable, IJsonModel<Kustomization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Kustomization>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Kustomization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Kustomization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Kustomization)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (!(DependsOn is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                if (DependsOn != null)
                {
                    writer.WritePropertyName("dependsOn"u8);
                    writer.WriteStartArray();
                    foreach (var item in DependsOn)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("dependsOn");
                }
            }
            if (TimeoutInSeconds.HasValue)
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (SyncIntervalInSeconds.HasValue)
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (RetryIntervalInSeconds.HasValue)
            {
                if (RetryIntervalInSeconds != null)
                {
                    writer.WritePropertyName("retryIntervalInSeconds"u8);
                    writer.WriteNumberValue(RetryIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("retryIntervalInSeconds");
                }
            }
            if (Prune.HasValue)
            {
                writer.WritePropertyName("prune"u8);
                writer.WriteBooleanValue(Prune.Value);
            }
            if (Force.HasValue)
            {
                writer.WritePropertyName("force"u8);
                writer.WriteBooleanValue(Force.Value);
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

        Kustomization IJsonModel<Kustomization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Kustomization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Kustomization)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustomization(document.RootElement, options);
        }

        internal static Kustomization DeserializeKustomization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string path = default;
            IList<string> dependsOn = default;
            long? timeoutInSeconds = default;
            long? syncIntervalInSeconds = default;
            long? retryIntervalInSeconds = default;
            bool? prune = default;
            bool? force = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dependsOn = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retryIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        retryIntervalInSeconds = null;
                        continue;
                    }
                    retryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("prune"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prune = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("force"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    force = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Kustomization(
                name,
                path,
                dependsOn ?? new ChangeTrackingList<string>(),
                timeoutInSeconds,
                syncIntervalInSeconds,
                retryIntervalInSeconds,
                prune,
                force,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Kustomization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Kustomization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Kustomization)} does not support '{options.Format}' format.");
            }
        }

        Kustomization IPersistableModel<Kustomization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Kustomization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKustomization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Kustomization)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Kustomization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
