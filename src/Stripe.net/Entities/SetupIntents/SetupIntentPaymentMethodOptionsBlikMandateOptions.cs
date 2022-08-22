// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SetupIntentPaymentMethodOptionsBlikMandateOptions : StripeEntity<SetupIntentPaymentMethodOptionsBlikMandateOptions>
    {
        /// <summary>
        /// Date at which the mandate expires.
        /// </summary>
        [JsonPropertyName("expires_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAfter { get; set; }

        [JsonPropertyName("off_session")]
        public SetupIntentPaymentMethodOptionsBlikMandateOptionsOffSession OffSession { get; set; }

        /// <summary>
        /// Type of the mandate.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
