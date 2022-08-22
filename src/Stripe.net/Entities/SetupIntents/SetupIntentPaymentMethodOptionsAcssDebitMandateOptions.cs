// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodOptionsAcssDebitMandateOptions : StripeEntity<SetupIntentPaymentMethodOptionsAcssDebitMandateOptions>
    {
        /// <summary>
        /// A URL for custom mandate text.
        /// </summary>
        [JsonPropertyName("custom_mandate_url")]
        public string CustomMandateUrl { get; set; }

        /// <summary>
        /// List of Stripe products where this mandate can be selected automatically.
        /// </summary>
        [JsonPropertyName("default_for")]
        public List<string> DefaultFor { get; set; }

        /// <summary>
        /// Description of the interval. Only required if the 'payment_schedule' parameter is
        /// 'interval' or 'combined'.
        /// </summary>
        [JsonPropertyName("interval_description")]
        public string IntervalDescription { get; set; }

        /// <summary>
        /// Payment schedule for the mandate.
        /// One of: <c>combined</c>, <c>interval</c>, or <c>sporadic</c>.
        /// </summary>
        [JsonPropertyName("payment_schedule")]
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Transaction type of the mandate.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }
    }
}
