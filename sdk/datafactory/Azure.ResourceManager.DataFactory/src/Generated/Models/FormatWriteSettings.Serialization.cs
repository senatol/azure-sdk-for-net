// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownFormatWriteSettings))]
    public partial class FormatWriteSettings : IUtf8JsonSerializable, IJsonModel<FormatWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FormatWriteSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FormatWriteSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FormatWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FormatWriteSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatWriteSettingsType);
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        FormatWriteSettings IJsonModel<FormatWriteSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FormatWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FormatWriteSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFormatWriteSettings(document.RootElement, options);
        }

        internal static FormatWriteSettings DeserializeFormatWriteSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroWriteSettings": return AvroWriteSettings.DeserializeAvroWriteSettings(element, options);
                    case "JsonWriteSettings": return JsonWriteSettings.DeserializeJsonWriteSettings(element, options);
                    case "OrcWriteSettings": return OrcWriteSettings.DeserializeOrcWriteSettings(element, options);
                    case "ParquetWriteSettings": return ParquetWriteSettings.DeserializeParquetWriteSettings(element, options);
                    case "DelimitedTextWriteSettings": return DelimitedTextWriteSettings.DeserializeDelimitedTextWriteSettings(element, options);
                }
            }
            return UnknownFormatWriteSettings.DeserializeUnknownFormatWriteSettings(element, options);
        }

        BinaryData IPersistableModel<FormatWriteSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FormatWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FormatWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        FormatWriteSettings IPersistableModel<FormatWriteSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FormatWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFormatWriteSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FormatWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FormatWriteSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
