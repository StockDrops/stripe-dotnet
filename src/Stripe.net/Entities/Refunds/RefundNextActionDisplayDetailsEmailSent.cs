// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class RefundNextActionDisplayDetailsEmailSent : StripeEntity<RefundNextActionDisplayDetailsEmailSent>
    {
        /// <summary>
        /// The timestamp when the email was sent.
        /// </summary>
        [JsonPropertyName("email_sent_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EmailSentAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The recipient's email address.
        /// </summary>
        [JsonPropertyName("email_sent_to")]
        public string EmailSentTo { get; set; }
    }
}
