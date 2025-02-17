// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceEnvironmentData : IUtf8JsonSerializable, IJsonModel<AppServiceEnvironmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceEnvironmentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceEnvironmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceEnvironmentData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (VirtualNetwork != null)
            {
                writer.WritePropertyName("virtualNetwork"u8);
                writer.WriteObjectValue(VirtualNetwork);
            }
            if (InternalLoadBalancingMode.HasValue)
            {
                writer.WritePropertyName("internalLoadBalancingMode"u8);
                writer.WriteStringValue(InternalLoadBalancingMode.Value.ToString());
            }
            if (MultiSize != null)
            {
                writer.WritePropertyName("multiSize"u8);
                writer.WriteStringValue(MultiSize);
            }
            if (options.Format != "W" && MultiRoleCount.HasValue)
            {
                writer.WritePropertyName("multiRoleCount"u8);
                writer.WriteNumberValue(MultiRoleCount.Value);
            }
            if (IPSslAddressCount.HasValue)
            {
                writer.WritePropertyName("ipsslAddressCount"u8);
                writer.WriteNumberValue(IPSslAddressCount.Value);
            }
            if (DnsSuffix != null)
            {
                writer.WritePropertyName("dnsSuffix"u8);
                writer.WriteStringValue(DnsSuffix);
            }
            if (options.Format != "W" && MaximumNumberOfMachines.HasValue)
            {
                writer.WritePropertyName("maximumNumberOfMachines"u8);
                writer.WriteNumberValue(MaximumNumberOfMachines.Value);
            }
            if (FrontEndScaleFactor.HasValue)
            {
                writer.WritePropertyName("frontEndScaleFactor"u8);
                writer.WriteNumberValue(FrontEndScaleFactor.Value);
            }
            if (options.Format != "W" && IsSuspended.HasValue)
            {
                writer.WritePropertyName("suspended"u8);
                writer.WriteBooleanValue(IsSuspended.Value);
            }
            if (!(ClusterSettings is ChangeTrackingList<AppServiceNameValuePair> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("clusterSettings"u8);
                writer.WriteStartArray();
                foreach (var item in ClusterSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(UserWhitelistedIPRanges is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("userWhitelistedIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in UserWhitelistedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && HasLinuxWorkers.HasValue)
            {
                writer.WritePropertyName("hasLinuxWorkers"u8);
                writer.WriteBooleanValue(HasLinuxWorkers.Value);
            }
            if (DedicatedHostCount.HasValue)
            {
                writer.WritePropertyName("dedicatedHostCount"u8);
                writer.WriteNumberValue(DedicatedHostCount.Value);
            }
            if (IsZoneRedundant.HasValue)
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            writer.WriteEndObject();
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

        AppServiceEnvironmentData IJsonModel<AppServiceEnvironmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceEnvironmentData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceEnvironmentData(document.RootElement, options);
        }

        internal static AppServiceEnvironmentData DeserializeAppServiceEnvironmentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ProvisioningState? provisioningState = default;
            HostingEnvironmentStatus? status = default;
            AppServiceVirtualNetworkProfile virtualNetwork = default;
            LoadBalancingMode? internalLoadBalancingMode = default;
            string multiSize = default;
            int? multiRoleCount = default;
            int? ipSslAddressCount = default;
            string dnsSuffix = default;
            int? maximumNumberOfMachines = default;
            int? frontEndScaleFactor = default;
            bool? suspended = default;
            IList<AppServiceNameValuePair> clusterSettings = default;
            IList<string> userWhitelistedIPRanges = default;
            bool? hasLinuxWorkers = default;
            int? dedicatedHostCount = default;
            bool? zoneRedundant = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToHostingEnvironmentStatus();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetwork = AppServiceVirtualNetworkProfile.DeserializeAppServiceVirtualNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("internalLoadBalancingMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalLoadBalancingMode = new LoadBalancingMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("multiSize"u8))
                        {
                            multiSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("multiRoleCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            multiRoleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipsslAddressCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipSslAddressCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dnsSuffix"u8))
                        {
                            dnsSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNumberOfMachines = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("frontEndScaleFactor"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontEndScaleFactor = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("suspended"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suspended = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clusterSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceNameValuePair> array = new List<AppServiceNameValuePair>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item, options));
                            }
                            clusterSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("userWhitelistedIpRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            userWhitelistedIPRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("hasLinuxWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasLinuxWorkers = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dedicatedHostCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dedicatedHostCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceEnvironmentData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                provisioningState,
                status,
                virtualNetwork,
                internalLoadBalancingMode,
                multiSize,
                multiRoleCount,
                ipSslAddressCount,
                dnsSuffix,
                maximumNumberOfMachines,
                frontEndScaleFactor,
                suspended,
                clusterSettings ?? new ChangeTrackingList<AppServiceNameValuePair>(),
                userWhitelistedIPRanges ?? new ChangeTrackingList<string>(),
                hasLinuxWorkers,
                dedicatedHostCount,
                zoneRedundant,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceEnvironmentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceEnvironmentData)} does not support '{options.Format}' format.");
            }
        }

        AppServiceEnvironmentData IPersistableModel<AppServiceEnvironmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceEnvironmentData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceEnvironmentData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceEnvironmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
