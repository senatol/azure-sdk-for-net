// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmConfiguration : IUtf8JsonSerializable, IJsonModel<BatchVmConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchVmConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchVmConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchVmConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("imageReference"u8);
            writer.WriteObjectValue(ImageReference);
            writer.WritePropertyName("nodeAgentSkuId"u8);
            writer.WriteStringValue(NodeAgentSkuId);
            if (WindowsConfiguration != null)
            {
                writer.WritePropertyName("windowsConfiguration"u8);
                writer.WriteObjectValue(WindowsConfiguration);
            }
            if (!(DataDisks is ChangeTrackingList<BatchVmDataDisk> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LicenseType != null)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (ContainerConfiguration != null)
            {
                writer.WritePropertyName("containerConfiguration"u8);
                writer.WriteObjectValue(ContainerConfiguration);
            }
            if (DiskEncryptionConfiguration != null)
            {
                writer.WritePropertyName("diskEncryptionConfiguration"u8);
                writer.WriteObjectValue(DiskEncryptionConfiguration);
            }
            if (NodePlacementConfiguration != null)
            {
                writer.WritePropertyName("nodePlacementConfiguration"u8);
                writer.WriteObjectValue(NodePlacementConfiguration);
            }
            if (!(Extensions is ChangeTrackingList<BatchVmExtension> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OSDisk != null)
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OSDisk);
            }
            if (SecurityProfile != null)
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (ServiceArtifactReference != null)
            {
                writer.WritePropertyName("serviceArtifactReference"u8);
                JsonSerializer.Serialize(writer, ServiceArtifactReference);
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

        BatchVmConfiguration IJsonModel<BatchVmConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchVmConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchVmConfiguration(document.RootElement, options);
        }

        internal static BatchVmConfiguration DeserializeBatchVmConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchImageReference imageReference = default;
            string nodeAgentSkuId = default;
            WindowsConfiguration windowsConfiguration = default;
            IList<BatchVmDataDisk> dataDisks = default;
            string licenseType = default;
            BatchVmContainerConfiguration containerConfiguration = default;
            DiskEncryptionConfiguration diskEncryptionConfiguration = default;
            NodePlacementConfiguration nodePlacementConfiguration = default;
            IList<BatchVmExtension> extensions = default;
            BatchOSDisk osDisk = default;
            BatchSecurityProfile securityProfile = default;
            WritableSubResource serviceArtifactReference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageReference"u8))
                {
                    imageReference = BatchImageReference.DeserializeBatchImageReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nodeAgentSkuId"u8))
                {
                    nodeAgentSkuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsConfiguration = WindowsConfiguration.DeserializeWindowsConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchVmDataDisk> array = new List<BatchVmDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchVmDataDisk.DeserializeBatchVmDataDisk(item, options));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerConfiguration = BatchVmContainerConfiguration.DeserializeBatchVmContainerConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diskEncryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionConfiguration = DiskEncryptionConfiguration.DeserializeDiskEncryptionConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nodePlacementConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodePlacementConfiguration = NodePlacementConfiguration.DeserializeNodePlacementConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchVmExtension> array = new List<BatchVmExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchVmExtension.DeserializeBatchVmExtension(item, options));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = BatchOSDisk.DeserializeBatchOSDisk(property.Value, options);
                    continue;
                }
                if (property.NameEquals("securityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityProfile = BatchSecurityProfile.DeserializeBatchSecurityProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceArtifactReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceArtifactReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchVmConfiguration(
                imageReference,
                nodeAgentSkuId,
                windowsConfiguration,
                dataDisks ?? new ChangeTrackingList<BatchVmDataDisk>(),
                licenseType,
                containerConfiguration,
                diskEncryptionConfiguration,
                nodePlacementConfiguration,
                extensions ?? new ChangeTrackingList<BatchVmExtension>(),
                osDisk,
                securityProfile,
                serviceArtifactReference,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchVmConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchVmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BatchVmConfiguration IPersistableModel<BatchVmConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchVmConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchVmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchVmConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
