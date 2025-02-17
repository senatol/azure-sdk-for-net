// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SitePatchInfo : IUtf8JsonSerializable, IJsonModel<SitePatchInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SitePatchInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SitePatchInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePatchInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SitePatchInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (options.Format != "W" && State != null)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && !(HostNames is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("hostNames"u8);
                writer.WriteStartArray();
                foreach (var item in HostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && RepositorySiteName != null)
            {
                writer.WritePropertyName("repositorySiteName"u8);
                writer.WriteStringValue(RepositorySiteName);
            }
            if (options.Format != "W" && UsageState.HasValue)
            {
                writer.WritePropertyName("usageState"u8);
                writer.WriteStringValue(UsageState.Value.ToSerialString());
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && !(EnabledHostNames is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("enabledHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in EnabledHostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && AvailabilityState.HasValue)
            {
                writer.WritePropertyName("availabilityState"u8);
                writer.WriteStringValue(AvailabilityState.Value.ToSerialString());
            }
            if (!(HostNameSslStates is ChangeTrackingList<HostNameSslState> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("hostNameSslStates"u8);
                writer.WriteStartArray();
                foreach (var item in HostNameSslStates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ServerFarmId != null)
            {
                writer.WritePropertyName("serverFarmId"u8);
                writer.WriteStringValue(ServerFarmId);
            }
            if (IsReserved.HasValue)
            {
                writer.WritePropertyName("reserved"u8);
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (IsXenon.HasValue)
            {
                writer.WritePropertyName("isXenon"u8);
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (IsHyperV.HasValue)
            {
                writer.WritePropertyName("hyperV"u8);
                writer.WriteBooleanValue(IsHyperV.Value);
            }
            if (options.Format != "W" && LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTimeUtc"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (SiteConfig != null)
            {
                writer.WritePropertyName("siteConfig"u8);
                writer.WriteObjectValue(SiteConfig);
            }
            if (options.Format != "W" && !(TrafficManagerHostNames is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("trafficManagerHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in TrafficManagerHostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsScmSiteAlsoStopped.HasValue)
            {
                writer.WritePropertyName("scmSiteAlsoStopped"u8);
                writer.WriteBooleanValue(IsScmSiteAlsoStopped.Value);
            }
            if (options.Format != "W" && TargetSwapSlot != null)
            {
                writer.WritePropertyName("targetSwapSlot"u8);
                writer.WriteStringValue(TargetSwapSlot);
            }
            if (HostingEnvironmentProfile != null)
            {
                writer.WritePropertyName("hostingEnvironmentProfile"u8);
                writer.WriteObjectValue(HostingEnvironmentProfile);
            }
            if (IsClientAffinityEnabled.HasValue)
            {
                writer.WritePropertyName("clientAffinityEnabled"u8);
                writer.WriteBooleanValue(IsClientAffinityEnabled.Value);
            }
            if (IsClientCertEnabled.HasValue)
            {
                writer.WritePropertyName("clientCertEnabled"u8);
                writer.WriteBooleanValue(IsClientCertEnabled.Value);
            }
            if (ClientCertMode.HasValue)
            {
                writer.WritePropertyName("clientCertMode"u8);
                writer.WriteStringValue(ClientCertMode.Value.ToSerialString());
            }
            if (ClientCertExclusionPaths != null)
            {
                writer.WritePropertyName("clientCertExclusionPaths"u8);
                writer.WriteStringValue(ClientCertExclusionPaths);
            }
            if (IsHostNameDisabled.HasValue)
            {
                writer.WritePropertyName("hostNamesDisabled"u8);
                writer.WriteBooleanValue(IsHostNameDisabled.Value);
            }
            if (CustomDomainVerificationId != null)
            {
                writer.WritePropertyName("customDomainVerificationId"u8);
                writer.WriteStringValue(CustomDomainVerificationId);
            }
            if (options.Format != "W" && OutboundIPAddresses != null)
            {
                writer.WritePropertyName("outboundIpAddresses"u8);
                writer.WriteStringValue(OutboundIPAddresses);
            }
            if (options.Format != "W" && PossibleOutboundIPAddresses != null)
            {
                writer.WritePropertyName("possibleOutboundIpAddresses"u8);
                writer.WriteStringValue(PossibleOutboundIPAddresses);
            }
            if (ContainerSize.HasValue)
            {
                writer.WritePropertyName("containerSize"u8);
                writer.WriteNumberValue(ContainerSize.Value);
            }
            if (DailyMemoryTimeQuota.HasValue)
            {
                writer.WritePropertyName("dailyMemoryTimeQuota"u8);
                writer.WriteNumberValue(DailyMemoryTimeQuota.Value);
            }
            if (options.Format != "W" && SuspendOn.HasValue)
            {
                writer.WritePropertyName("suspendedTill"u8);
                writer.WriteStringValue(SuspendOn.Value, "O");
            }
            if (options.Format != "W" && MaxNumberOfWorkers.HasValue)
            {
                writer.WritePropertyName("maxNumberOfWorkers"u8);
                writer.WriteNumberValue(MaxNumberOfWorkers.Value);
            }
            if (CloningInfo != null)
            {
                writer.WritePropertyName("cloningInfo"u8);
                writer.WriteObjectValue(CloningInfo);
            }
            if (options.Format != "W" && ResourceGroup != null)
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (options.Format != "W" && IsDefaultContainer.HasValue)
            {
                writer.WritePropertyName("isDefaultContainer"u8);
                writer.WriteBooleanValue(IsDefaultContainer.Value);
            }
            if (options.Format != "W" && DefaultHostName != null)
            {
                writer.WritePropertyName("defaultHostName"u8);
                writer.WriteStringValue(DefaultHostName);
            }
            if (options.Format != "W" && SlotSwapStatus != null)
            {
                writer.WritePropertyName("slotSwapStatus"u8);
                writer.WriteObjectValue(SlotSwapStatus);
            }
            if (IsHttpsOnly.HasValue)
            {
                writer.WritePropertyName("httpsOnly"u8);
                writer.WriteBooleanValue(IsHttpsOnly.Value);
            }
            if (RedundancyMode.HasValue)
            {
                writer.WritePropertyName("redundancyMode"u8);
                writer.WriteStringValue(RedundancyMode.Value.ToSerialString());
            }
            if (options.Format != "W" && InProgressOperationId.HasValue)
            {
                writer.WritePropertyName("inProgressOperationId"u8);
                writer.WriteStringValue(InProgressOperationId.Value);
            }
            if (IsStorageAccountRequired.HasValue)
            {
                writer.WritePropertyName("storageAccountRequired"u8);
                writer.WriteBooleanValue(IsStorageAccountRequired.Value);
            }
            if (KeyVaultReferenceIdentity != null)
            {
                writer.WritePropertyName("keyVaultReferenceIdentity"u8);
                writer.WriteStringValue(KeyVaultReferenceIdentity);
            }
            if (VirtualNetworkSubnetId != null)
            {
                writer.WritePropertyName("virtualNetworkSubnetId"u8);
                writer.WriteStringValue(VirtualNetworkSubnetId);
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

        SitePatchInfo IJsonModel<SitePatchInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePatchInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SitePatchInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSitePatchInfo(document.RootElement, options);
        }

        internal static SitePatchInfo DeserializeSitePatchInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string state = default;
            IReadOnlyList<string> hostNames = default;
            string repositorySiteName = default;
            AppServiceUsageState? usageState = default;
            bool? enabled = default;
            IReadOnlyList<string> enabledHostNames = default;
            WebSiteAvailabilityState? availabilityState = default;
            IList<HostNameSslState> hostNameSslStates = default;
            ResourceIdentifier serverFarmId = default;
            bool? reserved = default;
            bool? isXenon = default;
            bool? hyperV = default;
            DateTimeOffset? lastModifiedTimeUtc = default;
            SiteConfigProperties siteConfig = default;
            IReadOnlyList<string> trafficManagerHostNames = default;
            bool? scmSiteAlsoStopped = default;
            string targetSwapSlot = default;
            HostingEnvironmentProfile hostingEnvironmentProfile = default;
            bool? clientAffinityEnabled = default;
            bool? clientCertEnabled = default;
            ClientCertMode? clientCertMode = default;
            string clientCertExclusionPaths = default;
            bool? hostNamesDisabled = default;
            string customDomainVerificationId = default;
            string outboundIPAddresses = default;
            string possibleOutboundIPAddresses = default;
            int? containerSize = default;
            int? dailyMemoryTimeQuota = default;
            DateTimeOffset? suspendedTill = default;
            int? maxNumberOfWorkers = default;
            CloningInfo cloningInfo = default;
            string resourceGroup = default;
            bool? isDefaultContainer = default;
            string defaultHostName = default;
            SlotSwapStatus slotSwapStatus = default;
            bool? httpsOnly = default;
            RedundancyMode? redundancyMode = default;
            Guid? inProgressOperationId = default;
            bool? storageAccountRequired = default;
            string keyVaultReferenceIdentity = default;
            ResourceIdentifier virtualNetworkSubnetId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNames"u8))
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
                            hostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("repositorySiteName"u8))
                        {
                            repositorySiteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageState = property0.Value.GetString().ToAppServiceUsageState();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enabledHostNames"u8))
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
                            enabledHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("availabilityState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityState = property0.Value.GetString().ToWebSiteAvailabilityState();
                            continue;
                        }
                        if (property0.NameEquals("hostNameSslStates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HostNameSslState> array = new List<HostNameSslState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HostNameSslState.DeserializeHostNameSslState(item, options));
                            }
                            hostNameSslStates = array;
                            continue;
                        }
                        if (property0.NameEquals("serverFarmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverFarmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reserved"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reserved = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hyperV"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperV = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("siteConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            siteConfig = SiteConfigProperties.DeserializeSiteConfigProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("trafficManagerHostNames"u8))
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
                            trafficManagerHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("scmSiteAlsoStopped"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scmSiteAlsoStopped = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("targetSwapSlot"u8))
                        {
                            targetSwapSlot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clientAffinityEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientAffinityEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientCertEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientCertEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientCertMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientCertMode = property0.Value.GetString().ToClientCertMode();
                            continue;
                        }
                        if (property0.NameEquals("clientCertExclusionPaths"u8))
                        {
                            clientCertExclusionPaths = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNamesDisabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostNamesDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationId"u8))
                        {
                            customDomainVerificationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outboundIpAddresses"u8))
                        {
                            outboundIPAddresses = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("possibleOutboundIpAddresses"u8))
                        {
                            possibleOutboundIPAddresses = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dailyMemoryTimeQuota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailyMemoryTimeQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("suspendedTill"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suspendedTill = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("cloningInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloningInfo = CloningInfo.DeserializeCloningInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDefaultContainer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDefaultContainer = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultHostName"u8))
                        {
                            defaultHostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("slotSwapStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            slotSwapStatus = SlotSwapStatus.DeserializeSlotSwapStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("httpsOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpsOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("redundancyMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redundancyMode = property0.Value.GetString().ToRedundancyMode();
                            continue;
                        }
                        if (property0.NameEquals("inProgressOperationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inProgressOperationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReferenceIdentity"u8))
                        {
                            keyVaultReferenceIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkSubnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkSubnetId = new ResourceIdentifier(property0.Value.GetString());
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
            return new SitePatchInfo(
                id,
                name,
                type,
                systemData,
                identity,
                state,
                hostNames ?? new ChangeTrackingList<string>(),
                repositorySiteName,
                usageState,
                enabled,
                enabledHostNames ?? new ChangeTrackingList<string>(),
                availabilityState,
                hostNameSslStates ?? new ChangeTrackingList<HostNameSslState>(),
                serverFarmId,
                reserved,
                isXenon,
                hyperV,
                lastModifiedTimeUtc,
                siteConfig,
                trafficManagerHostNames ?? new ChangeTrackingList<string>(),
                scmSiteAlsoStopped,
                targetSwapSlot,
                hostingEnvironmentProfile,
                clientAffinityEnabled,
                clientCertEnabled,
                clientCertMode,
                clientCertExclusionPaths,
                hostNamesDisabled,
                customDomainVerificationId,
                outboundIPAddresses,
                possibleOutboundIPAddresses,
                containerSize,
                dailyMemoryTimeQuota,
                suspendedTill,
                maxNumberOfWorkers,
                cloningInfo,
                resourceGroup,
                isDefaultContainer,
                defaultHostName,
                slotSwapStatus,
                httpsOnly,
                redundancyMode,
                inProgressOperationId,
                storageAccountRequired,
                keyVaultReferenceIdentity,
                virtualNetworkSubnetId,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SitePatchInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePatchInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SitePatchInfo)} does not support '{options.Format}' format.");
            }
        }

        SitePatchInfo IPersistableModel<SitePatchInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SitePatchInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSitePatchInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SitePatchInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SitePatchInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
