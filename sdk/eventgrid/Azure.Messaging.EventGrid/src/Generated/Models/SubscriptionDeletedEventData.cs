// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.EventGrid.SubscriptionDeletedEvent. </summary>
    internal partial class SubscriptionDeletedEventData
    {
        /// <summary> Initializes a new instance of SubscriptionDeletedEventData. </summary>
        internal SubscriptionDeletedEventData()
        {
        }

        /// <summary> The Azure resource ID of the deleted event subscription. </summary>
        public string EventSubscriptionId { get; }
    }
}
