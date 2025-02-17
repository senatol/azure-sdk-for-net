// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppHostKeys : IUtf8JsonSerializable, IJsonModel<FunctionAppHostKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionAppHostKeys>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FunctionAppHostKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppHostKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionAppHostKeys)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MasterKey != null)
            {
                writer.WritePropertyName("masterKey"u8);
                writer.WriteStringValue(MasterKey);
            }
            if (!(FunctionKeys is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("functionKeys"u8);
                writer.WriteStartObject();
                foreach (var item in FunctionKeys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(SystemKeys is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("systemKeys"u8);
                writer.WriteStartObject();
                foreach (var item in SystemKeys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        FunctionAppHostKeys IJsonModel<FunctionAppHostKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppHostKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionAppHostKeys)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionAppHostKeys(document.RootElement, options);
        }

        internal static FunctionAppHostKeys DeserializeFunctionAppHostKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string masterKey = default;
            IReadOnlyDictionary<string, string> functionKeys = default;
            IReadOnlyDictionary<string, string> systemKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("masterKey"u8))
                {
                    masterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    functionKeys = dictionary;
                    continue;
                }
                if (property.NameEquals("systemKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    systemKeys = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FunctionAppHostKeys(masterKey, functionKeys ?? new ChangeTrackingDictionary<string, string>(), systemKeys ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FunctionAppHostKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppHostKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionAppHostKeys)} does not support '{options.Format}' format.");
            }
        }

        FunctionAppHostKeys IPersistableModel<FunctionAppHostKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppHostKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFunctionAppHostKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionAppHostKeys)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionAppHostKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
