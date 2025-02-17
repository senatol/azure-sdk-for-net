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
    public partial class KubernetesClusterBackupDataSourceSettings : IUtf8JsonSerializable, IJsonModel<KubernetesClusterBackupDataSourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesClusterBackupDataSourceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesClusterBackupDataSourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterBackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterBackupDataSourceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("snapshotVolumes"u8);
            writer.WriteBooleanValue(IsSnapshotVolumesEnabled);
            writer.WritePropertyName("includeClusterScopeResources"u8);
            writer.WriteBooleanValue(IsClusterScopeResourcesIncluded);
            if (!(IncludedNamespaces is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("includedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExcludedNamespaces is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("excludedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(IncludedResourceTypes is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("includedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExcludedResourceTypes is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("excludedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LabelSelectors is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("labelSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in LabelSelectors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(BackupHookReferences is ChangeTrackingList<NamespacedName> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("backupHookReferences"u8);
                writer.WriteStartArray();
                foreach (var item in BackupHookReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        KubernetesClusterBackupDataSourceSettings IJsonModel<KubernetesClusterBackupDataSourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterBackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterBackupDataSourceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesClusterBackupDataSourceSettings(document.RootElement, options);
        }

        internal static KubernetesClusterBackupDataSourceSettings DeserializeKubernetesClusterBackupDataSourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool snapshotVolumes = default;
            bool includeClusterScopeResources = default;
            IList<string> includedNamespaces = default;
            IList<string> excludedNamespaces = default;
            IList<string> includedResourceTypes = default;
            IList<string> excludedResourceTypes = default;
            IList<string> labelSelectors = default;
            IList<NamespacedName> backupHookReferences = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotVolumes"u8))
                {
                    snapshotVolumes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeClusterScopeResources"u8))
                {
                    includeClusterScopeResources = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includedNamespaces"u8))
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
                    includedNamespaces = array;
                    continue;
                }
                if (property.NameEquals("excludedNamespaces"u8))
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
                    excludedNamespaces = array;
                    continue;
                }
                if (property.NameEquals("includedResourceTypes"u8))
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
                    includedResourceTypes = array;
                    continue;
                }
                if (property.NameEquals("excludedResourceTypes"u8))
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
                    excludedResourceTypes = array;
                    continue;
                }
                if (property.NameEquals("labelSelectors"u8))
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
                    labelSelectors = array;
                    continue;
                }
                if (property.NameEquals("backupHookReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NamespacedName> array = new List<NamespacedName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NamespacedName.DeserializeNamespacedName(item, options));
                    }
                    backupHookReferences = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesClusterBackupDataSourceSettings(
                objectType,
                serializedAdditionalRawData,
                snapshotVolumes,
                includeClusterScopeResources,
                includedNamespaces ?? new ChangeTrackingList<string>(),
                excludedNamespaces ?? new ChangeTrackingList<string>(),
                includedResourceTypes ?? new ChangeTrackingList<string>(),
                excludedResourceTypes ?? new ChangeTrackingList<string>(),
                labelSelectors ?? new ChangeTrackingList<string>(),
                backupHookReferences ?? new ChangeTrackingList<NamespacedName>());
        }

        BinaryData IPersistableModel<KubernetesClusterBackupDataSourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterBackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterBackupDataSourceSettings)} does not support '{options.Format}' format.");
            }
        }

        KubernetesClusterBackupDataSourceSettings IPersistableModel<KubernetesClusterBackupDataSourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterBackupDataSourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesClusterBackupDataSourceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterBackupDataSourceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesClusterBackupDataSourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
