// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SubProtectionPolicy : IUtf8JsonSerializable, IJsonModel<SubProtectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubProtectionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SubProtectionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubProtectionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PolicyType.HasValue)
            {
                writer.WritePropertyName("policyType"u8);
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (SchedulePolicy != null)
            {
                writer.WritePropertyName("schedulePolicy"u8);
                writer.WriteObjectValue(SchedulePolicy);
            }
            if (RetentionPolicy != null)
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (!(TieringPolicy is ChangeTrackingDictionary<string, BackupTieringPolicy> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tieringPolicy"u8);
                writer.WriteStartObject();
                foreach (var item in TieringPolicy)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (SnapshotBackupAdditionalDetails != null)
            {
                writer.WritePropertyName("snapshotBackupAdditionalDetails"u8);
                writer.WriteObjectValue(SnapshotBackupAdditionalDetails);
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

        SubProtectionPolicy IJsonModel<SubProtectionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubProtectionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubProtectionPolicy(document.RootElement, options);
        }

        internal static SubProtectionPolicy DeserializeSubProtectionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SubProtectionPolicyType? policyType = default;
            BackupSchedulePolicy schedulePolicy = default;
            BackupRetentionPolicy retentionPolicy = default;
            IDictionary<string, BackupTieringPolicy> tieringPolicy = default;
            SnapshotBackupAdditionalDetails snapshotBackupAdditionalDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyType = new SubProtectionPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedulePolicy = BackupSchedulePolicy.DeserializeBackupSchedulePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPolicy = BackupRetentionPolicy.DeserializeBackupRetentionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tieringPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BackupTieringPolicy> dictionary = new Dictionary<string, BackupTieringPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, BackupTieringPolicy.DeserializeBackupTieringPolicy(property0.Value, options));
                    }
                    tieringPolicy = dictionary;
                    continue;
                }
                if (property.NameEquals("snapshotBackupAdditionalDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotBackupAdditionalDetails = SnapshotBackupAdditionalDetails.DeserializeSnapshotBackupAdditionalDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubProtectionPolicy(
                policyType,
                schedulePolicy,
                retentionPolicy,
                tieringPolicy ?? new ChangeTrackingDictionary<string, BackupTieringPolicy>(),
                snapshotBackupAdditionalDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubProtectionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        SubProtectionPolicy IPersistableModel<SubProtectionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubProtectionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubProtectionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
