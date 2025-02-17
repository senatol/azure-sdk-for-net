// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class BulkRegistryOperationResponse
    {
        internal static BulkRegistryOperationResponse DeserializeBulkRegistryOperationResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isSuccessful = default;
            IReadOnlyList<DeviceRegistryOperationError> errors = default;
            IReadOnlyList<DeviceRegistryOperationWarning> warnings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSuccessful"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSuccessful = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryOperationError> array = new List<DeviceRegistryOperationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryOperationError.DeserializeDeviceRegistryOperationError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryOperationWarning> array = new List<DeviceRegistryOperationWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryOperationWarning.DeserializeDeviceRegistryOperationWarning(item));
                    }
                    warnings = array;
                    continue;
                }
            }
            return new BulkRegistryOperationResponse(isSuccessful, errors ?? new ChangeTrackingList<DeviceRegistryOperationError>(), warnings ?? new ChangeTrackingList<DeviceRegistryOperationWarning>());
        }
    }
}
