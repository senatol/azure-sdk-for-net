// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Linked resource is reference to a resource deployed in an Azure subscription, add the linked resource `uniqueName` value as an optional parameter for operations on Azure Maps Geospatial REST APIs. </summary>
    public partial class MapsLinkedResource
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

        /// <summary> Initializes a new instance of <see cref="MapsLinkedResource"/>. </summary>
        /// <param name="uniqueName"> A provided name which uniquely identifies the linked resource. </param>
        /// <param name="id"> ARM resource id in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/accounts/{storageName}'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uniqueName"/> or <paramref name="id"/> is null. </exception>
        public MapsLinkedResource(string uniqueName, string id)
        {
            if (uniqueName == null)
            {
                throw new ArgumentNullException(nameof(uniqueName));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            UniqueName = uniqueName;
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="MapsLinkedResource"/>. </summary>
        /// <param name="uniqueName"> A provided name which uniquely identifies the linked resource. </param>
        /// <param name="id"> ARM resource id in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/accounts/{storageName}'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MapsLinkedResource(string uniqueName, string id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UniqueName = uniqueName;
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MapsLinkedResource"/> for deserialization. </summary>
        internal MapsLinkedResource()
        {
        }

        /// <summary> A provided name which uniquely identifies the linked resource. </summary>
        public string UniqueName { get; set; }
        /// <summary> ARM resource id in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/accounts/{storageName}'. </summary>
        public string Id { get; set; }
    }
}
