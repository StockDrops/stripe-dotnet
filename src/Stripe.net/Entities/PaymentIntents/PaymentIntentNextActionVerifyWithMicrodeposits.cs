// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionVerifyWithMicrodeposits : StripeEntity<PaymentIntentNextActionVerifyWithMicrodeposits>
    {
        /// <summary>
        /// The timestamp when the microdeposits are expected to land.
        /// </summary>
        [JsonPropertyName("arrival_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ArrivalDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the hosted verification page, which allows customers to verify their bank
        /// account.
        /// </summary>
        [JsonPropertyName("hosted_verification_url")]
        public string HostedVerificationUrl { get; set; }

        /// <summary>
        /// The type of the microdeposit sent to the customer. Used to distinguish between different
        /// verification methods.
        /// One of: <c>amounts</c>, or <c>descriptor_code</c>.
        /// </summary>
        [JsonPropertyName("microdeposit_type")]
        public string MicrodepositType { get; set; }
    }
}
