// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// Usage records allow you to report customer usage and metrics to Stripe for metered
    /// billing of subscription prices.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/billing/subscriptions/metered-billing">Metered
    /// Billing</a>.
    /// </summary>
    public class UsageRecord : StripeEntity<UsageRecord>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The usage quantity for the specified date.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The ID of the subscription item this usage record contains data for.
        /// </summary>
        [JsonPropertyName("subscription_item")]
        public string SubscriptionItem { get; set; }

        /// <summary>
        /// The timestamp when this usage occurred.
        /// </summary>
        [JsonPropertyName("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
