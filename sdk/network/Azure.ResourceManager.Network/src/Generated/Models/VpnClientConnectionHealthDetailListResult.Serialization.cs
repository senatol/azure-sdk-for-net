// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConnectionHealthDetailListResult : IUtf8JsonSerializable, IJsonModel<VpnClientConnectionHealthDetailListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnClientConnectionHealthDetailListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnClientConnectionHealthDetailListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetailListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetailListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<VpnClientConnectionHealthDetail> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        VpnClientConnectionHealthDetailListResult IJsonModel<VpnClientConnectionHealthDetailListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetailListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetailListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnClientConnectionHealthDetailListResult(document.RootElement, options);
        }

        internal static VpnClientConnectionHealthDetailListResult DeserializeVpnClientConnectionHealthDetailListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<VpnClientConnectionHealthDetail> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VpnClientConnectionHealthDetail> array = new List<VpnClientConnectionHealthDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnClientConnectionHealthDetail.DeserializeVpnClientConnectionHealthDetail(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnClientConnectionHealthDetailListResult(value ?? new ChangeTrackingList<VpnClientConnectionHealthDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnClientConnectionHealthDetailListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetailListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetailListResult)} does not support '{options.Format}' format.");
            }
        }

        VpnClientConnectionHealthDetailListResult IPersistableModel<VpnClientConnectionHealthDetailListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetailListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnClientConnectionHealthDetailListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetailListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnClientConnectionHealthDetailListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
