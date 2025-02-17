// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The ip configuration for a container network interface. </summary>
    public partial class ContainerNetworkInterfaceIPConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ContainerNetworkInterfaceIPConfiguration"/>. </summary>
        internal ContainerNetworkInterfaceIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerNetworkInterfaceIPConfiguration"/>. </summary>
        /// <param name="name"> The name of the resource. This name can be used to access the resource. </param>
        /// <param name="containerNetworkInterfaceIPConfigurationType"> Sub Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the container network interface IP configuration resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerNetworkInterfaceIPConfiguration(string name, string containerNetworkInterfaceIPConfigurationType, ETag? etag, NetworkProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ContainerNetworkInterfaceIpConfigurationType = containerNetworkInterfaceIPConfigurationType;
            ETag = etag;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the resource. This name can be used to access the resource. </summary>
        public string Name { get; }
        /// <summary> Sub Resource type. </summary>
        public string ContainerNetworkInterfaceIpConfigurationType { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The provisioning state of the container network interface IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
