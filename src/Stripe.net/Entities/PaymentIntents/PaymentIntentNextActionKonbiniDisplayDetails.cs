// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionKonbiniDisplayDetails : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetails>
    {
        /// <summary>
        /// The timestamp at which the pending Konbini payment expires.
        /// </summary>
        [JsonPropertyName("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the Konbini payment instructions page, which allows customers to view and
        /// print a Konbini voucher.
        /// </summary>
        [JsonPropertyName("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        [JsonPropertyName("stores")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStores Stores { get; set; }
    }
}
