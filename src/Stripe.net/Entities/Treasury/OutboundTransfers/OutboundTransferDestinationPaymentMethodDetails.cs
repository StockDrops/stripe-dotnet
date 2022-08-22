// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundTransferDestinationPaymentMethodDetails : StripeEntity<OutboundTransferDestinationPaymentMethodDetails>
    {
        [JsonPropertyName("billing_details")]
        public OutboundTransferDestinationPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The type of the payment method used in the OutboundTransfer.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public OutboundTransferDestinationPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
