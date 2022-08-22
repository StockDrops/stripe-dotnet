// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsBlikMandateOptionsOffSession : StripeEntity<SetupIntentPaymentMethodOptionsBlikMandateOptionsOffSession>
    {
        /// <summary>
        /// Amount of each recurring payment.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Currency of each recurring payment.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Frequency interval of each recurring payment.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Frequency indicator of each recurring payment.
        /// </summary>
        [JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
