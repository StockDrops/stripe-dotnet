// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundPaymentDestinationPaymentMethodDetailsFinancialAccount : StripeEntity<OutboundPaymentDestinationPaymentMethodDetailsFinancialAccount>, IHasId
    {
        /// <summary>
        /// Token of the FinancialAccount.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The rails used to send funds.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
