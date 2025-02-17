// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class LookingGlassOutput : IUtf8JsonSerializable, IJsonModel<LookingGlassOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LookingGlassOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LookingGlassOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookingGlassOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LookingGlassOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Command.HasValue)
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStringValue(Command.Value.ToString());
            }
            if (Output != null)
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStringValue(Output);
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

        LookingGlassOutput IJsonModel<LookingGlassOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookingGlassOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LookingGlassOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLookingGlassOutput(document.RootElement, options);
        }

        internal static LookingGlassOutput DeserializeLookingGlassOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LookingGlassCommand? command = default;
            string output = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("command"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    command = new LookingGlassCommand(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    output = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LookingGlassOutput(command, output, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LookingGlassOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookingGlassOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LookingGlassOutput)} does not support '{options.Format}' format.");
            }
        }

        LookingGlassOutput IPersistableModel<LookingGlassOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookingGlassOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLookingGlassOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LookingGlassOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LookingGlassOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
