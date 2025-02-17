// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureStorageAccountCredential : IUtf8JsonSerializable, IJsonModel<AzureStorageAccountCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureStorageAccountCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureStorageAccountCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageAccountCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureStorageAccountCredential)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (StorageAccountId != null)
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (!(ContainerCredentials is ChangeTrackingList<AzureStorageAccountContainerCredential> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("containerCredentials"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerCredentials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Expiry.HasValue)
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(Expiry.Value, "O");
            }
            writer.WritePropertyName("credentialType"u8);
            writer.WriteStringValue(CredentialType.ToString());
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

        AzureStorageAccountCredential IJsonModel<AzureStorageAccountCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageAccountCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureStorageAccountCredential)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureStorageAccountCredential(document.RootElement, options);
        }

        internal static AzureStorageAccountCredential DeserializeAzureStorageAccountCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier storageAccountId = default;
            IReadOnlyList<AzureStorageAccountContainerCredential> containerCredentials = default;
            DateTimeOffset? expiry = default;
            CredentialType credentialType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureStorageAccountContainerCredential> array = new List<AzureStorageAccountContainerCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureStorageAccountContainerCredential.DeserializeAzureStorageAccountContainerCredential(item, options));
                    }
                    containerCredentials = array;
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("credentialType"u8))
                {
                    credentialType = new CredentialType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureStorageAccountCredential(credentialType, serializedAdditionalRawData, storageAccountId, containerCredentials ?? new ChangeTrackingList<AzureStorageAccountContainerCredential>(), expiry);
        }

        BinaryData IPersistableModel<AzureStorageAccountCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageAccountCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureStorageAccountCredential)} does not support '{options.Format}' format.");
            }
        }

        AzureStorageAccountCredential IPersistableModel<AzureStorageAccountCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageAccountCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureStorageAccountCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureStorageAccountCredential)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureStorageAccountCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
