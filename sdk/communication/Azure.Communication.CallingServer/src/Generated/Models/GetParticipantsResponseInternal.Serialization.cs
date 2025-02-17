// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class GetParticipantsResponseInternal
    {
        internal static GetParticipantsResponseInternal DeserializeGetParticipantsResponseInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AcsCallParticipantInternal> values = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsCallParticipantInternal> array = new List<AcsCallParticipantInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsCallParticipantInternal.DeserializeAcsCallParticipantInternal(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GetParticipantsResponseInternal(values ?? new ChangeTrackingList<AcsCallParticipantInternal>(), nextLink);
        }
    }
}
