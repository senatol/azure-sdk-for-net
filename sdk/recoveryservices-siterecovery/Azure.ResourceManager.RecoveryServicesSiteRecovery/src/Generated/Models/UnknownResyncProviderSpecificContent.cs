// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownResyncProviderSpecificContent. </summary>
    internal partial class UnknownResyncProviderSpecificContent : ResyncProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownResyncProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownResyncProviderSpecificContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownResyncProviderSpecificContent"/> for deserialization. </summary>
        internal UnknownResyncProviderSpecificContent()
        {
        }
    }
}
