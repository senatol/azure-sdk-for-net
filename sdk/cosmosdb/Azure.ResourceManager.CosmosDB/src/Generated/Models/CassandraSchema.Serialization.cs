// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraSchema : IUtf8JsonSerializable, IJsonModel<CassandraSchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraSchema>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraSchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraSchema)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Columns is ChangeTrackingList<CassandraColumn> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PartitionKeys is ChangeTrackingList<CassandraPartitionKey> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("partitionKeys"u8);
                writer.WriteStartArray();
                foreach (var item in PartitionKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ClusterKeys is ChangeTrackingList<CassandraClusterKey> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("clusterKeys"u8);
                writer.WriteStartArray();
                foreach (var item in ClusterKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        CassandraSchema IJsonModel<CassandraSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraSchema)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraSchema(document.RootElement, options);
        }

        internal static CassandraSchema DeserializeCassandraSchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CassandraColumn> columns = default;
            IList<CassandraPartitionKey> partitionKeys = default;
            IList<CassandraClusterKey> clusterKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraColumn> array = new List<CassandraColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraColumn.DeserializeCassandraColumn(item, options));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("partitionKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraPartitionKey> array = new List<CassandraPartitionKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraPartitionKey.DeserializeCassandraPartitionKey(item, options));
                    }
                    partitionKeys = array;
                    continue;
                }
                if (property.NameEquals("clusterKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraClusterKey> array = new List<CassandraClusterKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraClusterKey.DeserializeCassandraClusterKey(item, options));
                    }
                    clusterKeys = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraSchema(columns ?? new ChangeTrackingList<CassandraColumn>(), partitionKeys ?? new ChangeTrackingList<CassandraPartitionKey>(), clusterKeys ?? new ChangeTrackingList<CassandraClusterKey>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraSchema>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraSchema)} does not support '{options.Format}' format.");
            }
        }

        CassandraSchema IPersistableModel<CassandraSchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraSchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraSchema)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
