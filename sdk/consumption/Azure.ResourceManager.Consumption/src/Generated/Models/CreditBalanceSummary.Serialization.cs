// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class CreditBalanceSummary : IUtf8JsonSerializable, IJsonModel<CreditBalanceSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreditBalanceSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreditBalanceSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreditBalanceSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreditBalanceSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && EstimatedBalance != null)
            {
                writer.WritePropertyName("estimatedBalance"u8);
                writer.WriteObjectValue(EstimatedBalance);
            }
            if (options.Format != "W" && CurrentBalance != null)
            {
                writer.WritePropertyName("currentBalance"u8);
                writer.WriteObjectValue(CurrentBalance);
            }
            if (options.Format != "W" && EstimatedBalanceInBillingCurrency != null)
            {
                writer.WritePropertyName("estimatedBalanceInBillingCurrency"u8);
                writer.WriteObjectValue(EstimatedBalanceInBillingCurrency);
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

        CreditBalanceSummary IJsonModel<CreditBalanceSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreditBalanceSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreditBalanceSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreditBalanceSummary(document.RootElement, options);
        }

        internal static CreditBalanceSummary DeserializeCreditBalanceSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConsumptionAmount estimatedBalance = default;
            ConsumptionAmount currentBalance = default;
            ConsumptionAmountWithExchangeRate estimatedBalanceInBillingCurrency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("estimatedBalance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedBalance = ConsumptionAmount.DeserializeConsumptionAmount(property.Value, options);
                    continue;
                }
                if (property.NameEquals("currentBalance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentBalance = ConsumptionAmount.DeserializeConsumptionAmount(property.Value, options);
                    continue;
                }
                if (property.NameEquals("estimatedBalanceInBillingCurrency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedBalanceInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreditBalanceSummary(estimatedBalance, currentBalance, estimatedBalanceInBillingCurrency, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreditBalanceSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreditBalanceSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreditBalanceSummary)} does not support '{options.Format}' format.");
            }
        }

        CreditBalanceSummary IPersistableModel<CreditBalanceSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreditBalanceSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreditBalanceSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreditBalanceSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreditBalanceSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
