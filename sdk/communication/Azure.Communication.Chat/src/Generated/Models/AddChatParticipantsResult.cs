// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Result of the add chat participants operation. </summary>
    public partial class AddChatParticipantsResult
    {
        /// <summary> Initializes a new instance of <see cref="AddChatParticipantsResult"/>. </summary>
        internal AddChatParticipantsResult()
        {
            InvalidParticipants = new ChangeTrackingList<ChatError>();
        }

        /// <summary> Initializes a new instance of <see cref="AddChatParticipantsResult"/>. </summary>
        /// <param name="invalidParticipants"> The participants that failed to be added to the chat thread. </param>
        internal AddChatParticipantsResult(IReadOnlyList<ChatError> invalidParticipants)
        {
            InvalidParticipants = invalidParticipants;
        }

        /// <summary> The participants that failed to be added to the chat thread. </summary>
        public IReadOnlyList<ChatError> InvalidParticipants { get; }
    }
}
