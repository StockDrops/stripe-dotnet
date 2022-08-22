// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionOxxoDisplayDetails : StripeEntity<PaymentIntentNextActionOxxoDisplayDetails>
    {
        /// <summary>
        /// The timestamp after which the OXXO voucher expires.
        /// </summary>
        [JsonPropertyName("expires_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAfter { get; set; }

        /// <summary>
        /// The URL for the hosted OXXO voucher page, which allows customers to view and print an
        /// OXXO voucher.
        /// </summary>
        [JsonPropertyName("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// OXXO reference number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
