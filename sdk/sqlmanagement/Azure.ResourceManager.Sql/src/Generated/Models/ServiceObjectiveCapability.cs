// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The service objectives capability. </summary>
    public partial class ServiceObjectiveCapability
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceObjectiveCapability"/>. </summary>
        internal ServiceObjectiveCapability()
        {
            SupportedMaxSizes = new ChangeTrackingList<MaxSizeRangeCapability>();
            SupportedLicenseTypes = new ChangeTrackingList<LicenseTypeCapability>();
            SupportedMinCapacities = new ChangeTrackingList<MinCapacityCapability>();
            SupportedMaintenanceConfigurations = new ChangeTrackingList<MaintenanceConfigurationCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceObjectiveCapability"/>. </summary>
        /// <param name="id"> The unique ID of the service objective. </param>
        /// <param name="name"> The service objective name. </param>
        /// <param name="supportedMaxSizes"> The list of supported maximum database sizes. </param>
        /// <param name="performanceLevel"> The performance level. </param>
        /// <param name="sku"> The sku. </param>
        /// <param name="supportedLicenseTypes"> List of supported license types. </param>
        /// <param name="includedMaxSize"> The included (free) max size. </param>
        /// <param name="isZoneRedundant"> Whether or not zone redundancy is supported for the service objective. </param>
        /// <param name="supportedAutoPauseDelay"> Supported time range for auto pause delay. </param>
        /// <param name="supportedMinCapacities"> List of supported min capacities. </param>
        /// <param name="computeModel"> The compute model. </param>
        /// <param name="supportedMaintenanceConfigurations"> List of supported maintenance configurations. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceObjectiveCapability(Guid? id, string name, IReadOnlyList<MaxSizeRangeCapability> supportedMaxSizes, PerformanceLevelCapability performanceLevel, SqlSku sku, IReadOnlyList<LicenseTypeCapability> supportedLicenseTypes, MaxSizeCapability includedMaxSize, bool? isZoneRedundant, AutoPauseDelayTimeRange supportedAutoPauseDelay, IReadOnlyList<MinCapacityCapability> supportedMinCapacities, string computeModel, IReadOnlyList<MaintenanceConfigurationCapability> supportedMaintenanceConfigurations, SqlCapabilityStatus? status, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            SupportedMaxSizes = supportedMaxSizes;
            PerformanceLevel = performanceLevel;
            Sku = sku;
            SupportedLicenseTypes = supportedLicenseTypes;
            IncludedMaxSize = includedMaxSize;
            IsZoneRedundant = isZoneRedundant;
            SupportedAutoPauseDelay = supportedAutoPauseDelay;
            SupportedMinCapacities = supportedMinCapacities;
            ComputeModel = computeModel;
            SupportedMaintenanceConfigurations = supportedMaintenanceConfigurations;
            Status = status;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unique ID of the service objective. </summary>
        public Guid? Id { get; }
        /// <summary> The service objective name. </summary>
        public string Name { get; }
        /// <summary> The list of supported maximum database sizes. </summary>
        public IReadOnlyList<MaxSizeRangeCapability> SupportedMaxSizes { get; }
        /// <summary> The performance level. </summary>
        public PerformanceLevelCapability PerformanceLevel { get; }
        /// <summary> The sku. </summary>
        public SqlSku Sku { get; }
        /// <summary> List of supported license types. </summary>
        public IReadOnlyList<LicenseTypeCapability> SupportedLicenseTypes { get; }
        /// <summary> The included (free) max size. </summary>
        public MaxSizeCapability IncludedMaxSize { get; }
        /// <summary> Whether or not zone redundancy is supported for the service objective. </summary>
        public bool? IsZoneRedundant { get; }
        /// <summary> Supported time range for auto pause delay. </summary>
        public AutoPauseDelayTimeRange SupportedAutoPauseDelay { get; }
        /// <summary> List of supported min capacities. </summary>
        public IReadOnlyList<MinCapacityCapability> SupportedMinCapacities { get; }
        /// <summary> The compute model. </summary>
        public string ComputeModel { get; }
        /// <summary> List of supported maintenance configurations. </summary>
        public IReadOnlyList<MaintenanceConfigurationCapability> SupportedMaintenanceConfigurations { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
