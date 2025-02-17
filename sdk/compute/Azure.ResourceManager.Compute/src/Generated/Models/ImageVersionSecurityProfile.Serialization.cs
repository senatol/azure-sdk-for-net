// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class ImageVersionSecurityProfile : IUtf8JsonSerializable, IJsonModel<ImageVersionSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageVersionSecurityProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageVersionSecurityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageVersionSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageVersionSecurityProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (UefiSettings != null)
            {
                writer.WritePropertyName("uefiSettings"u8);
                writer.WriteObjectValue(UefiSettings);
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

        ImageVersionSecurityProfile IJsonModel<ImageVersionSecurityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageVersionSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageVersionSecurityProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageVersionSecurityProfile(document.RootElement, options);
        }

        internal static ImageVersionSecurityProfile DeserializeImageVersionSecurityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GalleryImageVersionUefiSettings uefiSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uefiSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uefiSettings = GalleryImageVersionUefiSettings.DeserializeGalleryImageVersionUefiSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageVersionSecurityProfile(uefiSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageVersionSecurityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageVersionSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageVersionSecurityProfile)} does not support '{options.Format}' format.");
            }
        }

        ImageVersionSecurityProfile IPersistableModel<ImageVersionSecurityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageVersionSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageVersionSecurityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageVersionSecurityProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageVersionSecurityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
