// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SubscriptionPauseCollectionOptions : INestedOptions
    {
        /// <summary>
        /// The payment collection behavior for this subscription while paused. One of
        /// <c>keep_as_draft</c>, <c>mark_uncollectible</c>, or <c>void</c>.
        /// One of: <c>keep_as_draft</c>, <c>mark_uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonPropertyName("behavior")]
        public string Behavior { get; set; }

        /// <summary>
        /// The time after which the subscription will resume collecting payments.
        /// </summary>
        [JsonPropertyName("resumes_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ResumesAt { get; set; }
    }
}
