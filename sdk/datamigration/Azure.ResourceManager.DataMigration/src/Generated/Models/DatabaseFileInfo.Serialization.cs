// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseFileInfo : IUtf8JsonSerializable, IJsonModel<DatabaseFileInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseFileInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatabaseFileInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseFileInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DatabaseName != null)
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (LogicalName != null)
            {
                writer.WritePropertyName("logicalName"u8);
                writer.WriteStringValue(LogicalName);
            }
            if (PhysicalFullName != null)
            {
                writer.WritePropertyName("physicalFullName"u8);
                writer.WriteStringValue(PhysicalFullName);
            }
            if (RestoreFullName != null)
            {
                writer.WritePropertyName("restoreFullName"u8);
                writer.WriteStringValue(RestoreFullName);
            }
            if (FileType.HasValue)
            {
                writer.WritePropertyName("fileType"u8);
                writer.WriteStringValue(FileType.Value.ToString());
            }
            if (SizeMB.HasValue)
            {
                writer.WritePropertyName("sizeMB"u8);
                writer.WriteNumberValue(SizeMB.Value);
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

        DatabaseFileInfo IJsonModel<DatabaseFileInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseFileInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseFileInfo(document.RootElement, options);
        }

        internal static DatabaseFileInfo DeserializeDatabaseFileInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            string id = default;
            string logicalName = default;
            string physicalFullName = default;
            string restoreFullName = default;
            DatabaseFileType? fileType = default;
            double? sizeMB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logicalName"u8))
                {
                    logicalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalFullName"u8))
                {
                    physicalFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreFullName"u8))
                {
                    restoreFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileType = new DatabaseFileType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeMB = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatabaseFileInfo(
                databaseName,
                id,
                logicalName,
                physicalFullName,
                restoreFullName,
                fileType,
                sizeMB,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatabaseFileInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseFileInfo)} does not support '{options.Format}' format.");
            }
        }

        DatabaseFileInfo IPersistableModel<DatabaseFileInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseFileInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseFileInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseFileInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
