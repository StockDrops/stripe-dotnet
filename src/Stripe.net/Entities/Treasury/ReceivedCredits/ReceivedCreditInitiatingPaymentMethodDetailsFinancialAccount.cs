// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditInitiatingPaymentMethodDetailsFinancialAccount : StripeEntity<ReceivedCreditInitiatingPaymentMethodDetailsFinancialAccount>, IHasId
    {
        /// <summary>
        /// The FinancialAccount ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The rails the ReceivedCredit was sent over. A FinancialAccount can only send funds over
        /// <c>stripe</c>.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
