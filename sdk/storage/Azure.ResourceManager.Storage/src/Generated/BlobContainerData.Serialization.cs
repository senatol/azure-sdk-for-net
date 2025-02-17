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
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class BlobContainerData : IUtf8JsonSerializable, IJsonModel<BlobContainerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobContainerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BlobContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobContainerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobContainerData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (options.Format != "W" && Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && IsDeleted.HasValue)
            {
                writer.WritePropertyName("deleted"u8);
                writer.WriteBooleanValue(IsDeleted.Value);
            }
            if (options.Format != "W" && DeletedOn.HasValue)
            {
                writer.WritePropertyName("deletedTime"u8);
                writer.WriteStringValue(DeletedOn.Value, "O");
            }
            if (options.Format != "W" && RemainingRetentionDays.HasValue)
            {
                writer.WritePropertyName("remainingRetentionDays"u8);
                writer.WriteNumberValue(RemainingRetentionDays.Value);
            }
            if (DefaultEncryptionScope != null)
            {
                writer.WritePropertyName("defaultEncryptionScope"u8);
                writer.WriteStringValue(DefaultEncryptionScope);
            }
            if (PreventEncryptionScopeOverride.HasValue)
            {
                writer.WritePropertyName("denyEncryptionScopeOverride"u8);
                writer.WriteBooleanValue(PreventEncryptionScopeOverride.Value);
            }
            if (PublicAccess.HasValue)
            {
                writer.WritePropertyName("publicAccess"u8);
                writer.WriteStringValue(PublicAccess.Value.ToSerialString());
            }
            if (options.Format != "W" && LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && LeaseStatus.HasValue)
            {
                writer.WritePropertyName("leaseStatus"u8);
                writer.WriteStringValue(LeaseStatus.Value.ToString());
            }
            if (options.Format != "W" && LeaseState.HasValue)
            {
                writer.WritePropertyName("leaseState"u8);
                writer.WriteStringValue(LeaseState.Value.ToString());
            }
            if (options.Format != "W" && LeaseDuration.HasValue)
            {
                writer.WritePropertyName("leaseDuration"u8);
                writer.WriteStringValue(LeaseDuration.Value.ToString());
            }
            if (!(Metadata is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && ImmutabilityPolicy != null)
            {
                writer.WritePropertyName("immutabilityPolicy"u8);
                writer.WriteObjectValue(ImmutabilityPolicy);
            }
            if (options.Format != "W" && LegalHold != null)
            {
                writer.WritePropertyName("legalHold"u8);
                writer.WriteObjectValue(LegalHold);
            }
            if (options.Format != "W" && HasLegalHold.HasValue)
            {
                writer.WritePropertyName("hasLegalHold"u8);
                writer.WriteBooleanValue(HasLegalHold.Value);
            }
            if (options.Format != "W" && HasImmutabilityPolicy.HasValue)
            {
                writer.WritePropertyName("hasImmutabilityPolicy"u8);
                writer.WriteBooleanValue(HasImmutabilityPolicy.Value);
            }
            if (ImmutableStorageWithVersioning != null)
            {
                writer.WritePropertyName("immutableStorageWithVersioning"u8);
                writer.WriteObjectValue(ImmutableStorageWithVersioning);
            }
            if (EnableNfsV3RootSquash.HasValue)
            {
                writer.WritePropertyName("enableNfsV3RootSquash"u8);
                writer.WriteBooleanValue(EnableNfsV3RootSquash.Value);
            }
            if (EnableNfsV3AllSquash.HasValue)
            {
                writer.WritePropertyName("enableNfsV3AllSquash"u8);
                writer.WriteBooleanValue(EnableNfsV3AllSquash.Value);
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

        BlobContainerData IJsonModel<BlobContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobContainerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobContainerData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobContainerData(document.RootElement, options);
        }

        internal static BlobContainerData DeserializeBlobContainerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string version = default;
            bool? deleted = default;
            DateTimeOffset? deletedTime = default;
            int? remainingRetentionDays = default;
            string defaultEncryptionScope = default;
            bool? denyEncryptionScopeOverride = default;
            StoragePublicAccessType? publicAccess = default;
            DateTimeOffset? lastModifiedTime = default;
            StorageLeaseStatus? leaseStatus = default;
            StorageLeaseState? leaseState = default;
            StorageLeaseDurationType? leaseDuration = default;
            IDictionary<string, string> metadata = default;
            BlobContainerImmutabilityPolicy immutabilityPolicy = default;
            LegalHoldProperties legalHold = default;
            bool? hasLegalHold = default;
            bool? hasImmutabilityPolicy = default;
            ImmutableStorageWithVersioning immutableStorageWithVersioning = default;
            bool? enableNfsV3RootSquash = default;
            bool? enableNfsV3AllSquash = default;
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
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deletedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deletedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("remainingRetentionDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remainingRetentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("defaultEncryptionScope"u8))
                        {
                            defaultEncryptionScope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("denyEncryptionScopeOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            denyEncryptionScopeOverride = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicAccess = property0.Value.GetString().ToStoragePublicAccessType();
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
                        if (property0.NameEquals("leaseStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            leaseStatus = new StorageLeaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("leaseState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            leaseState = new StorageLeaseState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("leaseDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            leaseDuration = new StorageLeaseDurationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
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
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("immutabilityPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            immutabilityPolicy = BlobContainerImmutabilityPolicy.DeserializeBlobContainerImmutabilityPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("legalHold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            legalHold = LegalHoldProperties.DeserializeLegalHoldProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hasLegalHold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasLegalHold = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasImmutabilityPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasImmutabilityPolicy = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("immutableStorageWithVersioning"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            immutableStorageWithVersioning = ImmutableStorageWithVersioning.DeserializeImmutableStorageWithVersioning(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableNfsV3RootSquash"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableNfsV3RootSquash = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableNfsV3AllSquash"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableNfsV3AllSquash = property0.Value.GetBoolean();
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
            return new BlobContainerData(
                id,
                name,
                type,
                systemData,
                version,
                deleted,
                deletedTime,
                remainingRetentionDays,
                defaultEncryptionScope,
                denyEncryptionScopeOverride,
                publicAccess,
                lastModifiedTime,
                leaseStatus,
                leaseState,
                leaseDuration,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                immutabilityPolicy,
                legalHold,
                hasLegalHold,
                hasImmutabilityPolicy,
                immutableStorageWithVersioning,
                enableNfsV3RootSquash,
                enableNfsV3AllSquash,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlobContainerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobContainerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BlobContainerData)} does not support '{options.Format}' format.");
            }
        }

        BlobContainerData IPersistableModel<BlobContainerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobContainerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBlobContainerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobContainerData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
