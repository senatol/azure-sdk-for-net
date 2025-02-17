// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiOperationProperties : IUtf8JsonSerializable, IJsonModel<LogicApiOperationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiOperationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicApiOperationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiOperationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiOperationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Summary != null)
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Visibility != null)
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility);
            }
            if (Trigger != null)
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteStringValue(Trigger);
            }
            if (TriggerHint != null)
            {
                writer.WritePropertyName("triggerHint"u8);
                writer.WriteStringValue(TriggerHint);
            }
            if (IsPageable.HasValue)
            {
                writer.WritePropertyName("pageable"u8);
                writer.WriteBooleanValue(IsPageable.Value);
            }
            if (Annotation != null)
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteObjectValue(Annotation);
            }
            if (Api != null)
            {
                writer.WritePropertyName("api"u8);
                writer.WriteObjectValue(Api);
            }
            if (InputsDefinition != null)
            {
                writer.WritePropertyName("inputsDefinition"u8);
                writer.WriteObjectValue(InputsDefinition);
            }
            if (!(ResponsesDefinition is ChangeTrackingDictionary<string, SwaggerSchema> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("responsesDefinition"u8);
                writer.WriteStartObject();
                foreach (var item in ResponsesDefinition)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (IsWebhook.HasValue)
            {
                writer.WritePropertyName("isWebhook"u8);
                writer.WriteBooleanValue(IsWebhook.Value);
            }
            if (IsNotification.HasValue)
            {
                writer.WritePropertyName("isNotification"u8);
                writer.WriteBooleanValue(IsNotification.Value);
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

        LogicApiOperationProperties IJsonModel<LogicApiOperationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiOperationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiOperationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiOperationProperties(document.RootElement, options);
        }

        internal static LogicApiOperationProperties DeserializeLogicApiOperationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string summary = default;
            string description = default;
            string visibility = default;
            string trigger = default;
            string triggerHint = default;
            bool? pageable = default;
            LogicApiOperationAnnotation annotation = default;
            LogicApiReference api = default;
            SwaggerSchema inputsDefinition = default;
            IDictionary<string, SwaggerSchema> responsesDefinition = default;
            bool? isWebhook = default;
            bool? isNotification = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    visibility = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trigger"u8))
                {
                    trigger = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerHint"u8))
                {
                    triggerHint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pageable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pageable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("annotation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    annotation = LogicApiOperationAnnotation.DeserializeLogicApiOperationAnnotation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("api"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    api = LogicApiReference.DeserializeLogicApiReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("inputsDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputsDefinition = SwaggerSchema.DeserializeSwaggerSchema(property.Value, options);
                    continue;
                }
                if (property.NameEquals("responsesDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SwaggerSchema> dictionary = new Dictionary<string, SwaggerSchema>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SwaggerSchema.DeserializeSwaggerSchema(property0.Value, options));
                    }
                    responsesDefinition = dictionary;
                    continue;
                }
                if (property.NameEquals("isWebhook"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebhook = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNotification = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicApiOperationProperties(
                summary,
                description,
                visibility,
                trigger,
                triggerHint,
                pageable,
                annotation,
                api,
                inputsDefinition,
                responsesDefinition ?? new ChangeTrackingDictionary<string, SwaggerSchema>(),
                isWebhook,
                isNotification,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicApiOperationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiOperationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicApiOperationProperties)} does not support '{options.Format}' format.");
            }
        }

        LogicApiOperationProperties IPersistableModel<LogicApiOperationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiOperationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicApiOperationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicApiOperationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicApiOperationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
