// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupInstancePolicyInfo : IUtf8JsonSerializable, IJsonModel<BackupInstancePolicyInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupInstancePolicyInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupInstancePolicyInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupInstancePolicyInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("policyId"u8);
            writer.WriteStringValue(PolicyId);
            if (options.Format != "W" && PolicyVersion != null)
            {
                writer.WritePropertyName("policyVersion"u8);
                writer.WriteStringValue(PolicyVersion);
            }
            if (PolicyParameters != null)
            {
                writer.WritePropertyName("policyParameters"u8);
                writer.WriteObjectValue(PolicyParameters);
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

        BackupInstancePolicyInfo IJsonModel<BackupInstancePolicyInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupInstancePolicyInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupInstancePolicyInfo(document.RootElement, options);
        }

        internal static BackupInstancePolicyInfo DeserializeBackupInstancePolicyInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier policyId = default;
            string policyVersion = default;
            BackupInstancePolicySettings policyParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyId"u8))
                {
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyVersion"u8))
                {
                    policyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyParameters = BackupInstancePolicySettings.DeserializeBackupInstancePolicySettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupInstancePolicyInfo(policyId, policyVersion, policyParameters, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupInstancePolicyInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupInstancePolicyInfo)} does not support '{options.Format}' format.");
            }
        }

        BackupInstancePolicyInfo IPersistableModel<BackupInstancePolicyInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupInstancePolicyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupInstancePolicyInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupInstancePolicyInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupInstancePolicyInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
