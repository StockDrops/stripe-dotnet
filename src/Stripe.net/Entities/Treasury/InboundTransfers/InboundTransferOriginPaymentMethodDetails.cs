// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class InboundTransferOriginPaymentMethodDetails : StripeEntity<InboundTransferOriginPaymentMethodDetails>
    {
        [JsonPropertyName("billing_details")]
        public InboundTransferOriginPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The type of the payment method used in the InboundTransfer.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("us_bank_account")]
        public InboundTransferOriginPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
