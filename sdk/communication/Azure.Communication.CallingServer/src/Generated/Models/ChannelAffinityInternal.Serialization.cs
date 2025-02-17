// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class ChannelAffinityInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Channel.HasValue)
            {
                writer.WritePropertyName("channel"u8);
                writer.WriteNumberValue(Channel.Value);
            }
            if (Participant != null)
            {
                writer.WritePropertyName("participant"u8);
                writer.WriteObjectValue(Participant);
            }
            writer.WriteEndObject();
        }
    }
}
