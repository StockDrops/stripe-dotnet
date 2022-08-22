// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPaymentMethodOptionsCardInstallmentsPlanOptions : INestedOptions
    {
        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is the number of installment payments
        /// your customer will make to their credit card.
        /// </summary>
        [JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is the interval between installment
        /// payments your customer will make to their credit card. One of <c>month</c>.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Type of installment plan, one of <c>fixed_count</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
