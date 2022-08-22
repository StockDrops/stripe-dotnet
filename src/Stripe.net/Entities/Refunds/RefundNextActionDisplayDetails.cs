// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class RefundNextActionDisplayDetails : StripeEntity<RefundNextActionDisplayDetails>
    {
        [JsonPropertyName("email_sent")]
        public RefundNextActionDisplayDetailsEmailSent EmailSent { get; set; }

        /// <summary>
        /// The expiry timestamp.
        /// </summary>
        [JsonPropertyName("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
