// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class SecurityRuleAssociations : IUtf8JsonSerializable, IJsonModel<SecurityRuleAssociations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityRuleAssociations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityRuleAssociations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityRuleAssociations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityRuleAssociations)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (NetworkInterfaceAssociation != null)
            {
                writer.WritePropertyName("networkInterfaceAssociation"u8);
                writer.WriteObjectValue(NetworkInterfaceAssociation);
            }
            if (SubnetAssociation != null)
            {
                writer.WritePropertyName("subnetAssociation"u8);
                writer.WriteObjectValue(SubnetAssociation);
            }
            if (!(DefaultSecurityRules is ChangeTrackingList<SecurityRuleData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("defaultSecurityRules"u8);
                writer.WriteStartArray();
                foreach (var item in DefaultSecurityRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(EffectiveSecurityRules is ChangeTrackingList<EffectiveNetworkSecurityRule> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("effectiveSecurityRules"u8);
                writer.WriteStartArray();
                foreach (var item in EffectiveSecurityRules)
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

        SecurityRuleAssociations IJsonModel<SecurityRuleAssociations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityRuleAssociations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityRuleAssociations)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityRuleAssociations(document.RootElement, options);
        }

        internal static SecurityRuleAssociations DeserializeSecurityRuleAssociations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkInterfaceAssociation networkInterfaceAssociation = default;
            SubnetAssociation subnetAssociation = default;
            IReadOnlyList<SecurityRuleData> defaultSecurityRules = default;
            IReadOnlyList<EffectiveNetworkSecurityRule> effectiveSecurityRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaceAssociation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkInterfaceAssociation = NetworkInterfaceAssociation.DeserializeNetworkInterfaceAssociation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subnetAssociation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetAssociation = SubnetAssociation.DeserializeSubnetAssociation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("defaultSecurityRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityRuleData> array = new List<SecurityRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityRuleData.DeserializeSecurityRuleData(item, options));
                    }
                    defaultSecurityRules = array;
                    continue;
                }
                if (property.NameEquals("effectiveSecurityRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveNetworkSecurityRule> array = new List<EffectiveNetworkSecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveNetworkSecurityRule.DeserializeEffectiveNetworkSecurityRule(item, options));
                    }
                    effectiveSecurityRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityRuleAssociations(networkInterfaceAssociation, subnetAssociation, defaultSecurityRules ?? new ChangeTrackingList<SecurityRuleData>(), effectiveSecurityRules ?? new ChangeTrackingList<EffectiveNetworkSecurityRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityRuleAssociations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityRuleAssociations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityRuleAssociations)} does not support '{options.Format}' format.");
            }
        }

        SecurityRuleAssociations IPersistableModel<SecurityRuleAssociations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityRuleAssociations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityRuleAssociations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityRuleAssociations)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityRuleAssociations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
