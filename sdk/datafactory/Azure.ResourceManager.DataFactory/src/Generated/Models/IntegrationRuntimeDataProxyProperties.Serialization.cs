// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeDataProxyProperties : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeDataProxyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeDataProxyProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationRuntimeDataProxyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeDataProxyProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (StagingLinkedService != null)
            {
                writer.WritePropertyName("stagingLinkedService"u8);
                writer.WriteObjectValue(StagingLinkedService);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
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

        IntegrationRuntimeDataProxyProperties IJsonModel<IntegrationRuntimeDataProxyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeDataProxyProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeDataProxyProperties(document.RootElement, options);
        }

        internal static IntegrationRuntimeDataProxyProperties DeserializeIntegrationRuntimeDataProxyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntityReference connectVia = default;
            EntityReference stagingLinkedService = default;
            string path = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = EntityReference.DeserializeEntityReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stagingLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stagingLinkedService = EntityReference.DeserializeEntityReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationRuntimeDataProxyProperties(connectVia, stagingLinkedService, path, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationRuntimeDataProxyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeDataProxyProperties)} does not support '{options.Format}' format.");
            }
        }

        IntegrationRuntimeDataProxyProperties IPersistableModel<IntegrationRuntimeDataProxyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeDataProxyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeDataProxyProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeDataProxyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
