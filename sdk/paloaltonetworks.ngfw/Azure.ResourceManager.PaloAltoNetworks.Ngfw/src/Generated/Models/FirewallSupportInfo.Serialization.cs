// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallSupportInfo : IUtf8JsonSerializable, IJsonModel<FirewallSupportInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallSupportInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallSupportInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallSupportInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallSupportInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ProductSku != null)
            {
                writer.WritePropertyName("productSku"u8);
                writer.WriteStringValue(ProductSku);
            }
            if (ProductSerial != null)
            {
                writer.WritePropertyName("productSerial"u8);
                writer.WriteStringValue(ProductSerial);
            }
            if (AccountRegistered.HasValue)
            {
                writer.WritePropertyName("accountRegistered"u8);
                writer.WriteStringValue(AccountRegistered.Value.ToString());
            }
            if (AccountId != null)
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (UserDomainSupported.HasValue)
            {
                writer.WritePropertyName("userDomainSupported"u8);
                writer.WriteStringValue(UserDomainSupported.Value.ToString());
            }
            if (UserRegistered.HasValue)
            {
                writer.WritePropertyName("userRegistered"u8);
                writer.WriteStringValue(UserRegistered.Value.ToString());
            }
            if (FreeTrial.HasValue)
            {
                writer.WritePropertyName("freeTrial"u8);
                writer.WriteStringValue(FreeTrial.Value.ToString());
            }
            if (FreeTrialDaysLeft.HasValue)
            {
                writer.WritePropertyName("freeTrialDaysLeft"u8);
                writer.WriteNumberValue(FreeTrialDaysLeft.Value);
            }
            if (FreeTrialCreditLeft.HasValue)
            {
                writer.WritePropertyName("freeTrialCreditLeft"u8);
                writer.WriteNumberValue(FreeTrialCreditLeft.Value);
            }
            if (HelpURL != null)
            {
                writer.WritePropertyName("helpURL"u8);
                writer.WriteStringValue(HelpURL);
            }
            if (SupportURL != null)
            {
                writer.WritePropertyName("supportURL"u8);
                writer.WriteStringValue(SupportURL);
            }
            if (RegisterURL != null)
            {
                writer.WritePropertyName("registerURL"u8);
                writer.WriteStringValue(RegisterURL);
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

        FirewallSupportInfo IJsonModel<FirewallSupportInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallSupportInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallSupportInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallSupportInfo(document.RootElement, options);
        }

        internal static FirewallSupportInfo DeserializeFirewallSupportInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string productSku = default;
            string productSerial = default;
            FirewallBooleanType? accountRegistered = default;
            string accountId = default;
            FirewallBooleanType? userDomainSupported = default;
            FirewallBooleanType? userRegistered = default;
            FirewallBooleanType? freeTrial = default;
            int? freeTrialDaysLeft = default;
            int? freeTrialCreditLeft = default;
            string helpURL = default;
            string supportURL = default;
            string registerURL = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productSku"u8))
                {
                    productSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productSerial"u8))
                {
                    productSerial = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountRegistered"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountRegistered = new FirewallBooleanType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userDomainSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userDomainSupported = new FirewallBooleanType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userRegistered"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userRegistered = new FirewallBooleanType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("freeTrial"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    freeTrial = new FirewallBooleanType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("freeTrialDaysLeft"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    freeTrialDaysLeft = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("freeTrialCreditLeft"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    freeTrialCreditLeft = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("helpURL"u8))
                {
                    helpURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportURL"u8))
                {
                    supportURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registerURL"u8))
                {
                    registerURL = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallSupportInfo(
                productSku,
                productSerial,
                accountRegistered,
                accountId,
                userDomainSupported,
                userRegistered,
                freeTrial,
                freeTrialDaysLeft,
                freeTrialCreditLeft,
                helpURL,
                supportURL,
                registerURL,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallSupportInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallSupportInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallSupportInfo)} does not support '{options.Format}' format.");
            }
        }

        FirewallSupportInfo IPersistableModel<FirewallSupportInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallSupportInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallSupportInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallSupportInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallSupportInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
