// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundPaymentDestinationPaymentMethodDetails : StripeEntity<OutboundPaymentDestinationPaymentMethodDetails>
    {
        [JsonPropertyName("billing_details")]
        public OutboundPaymentDestinationPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonPropertyName("financial_account")]
        public OutboundPaymentDestinationPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// The type of the payment method used in the OutboundPayment.
        /// One of: <c>financial_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public OutboundPaymentDestinationPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
