// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundTransferDestinationPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>us_bank_account</c>.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public OutboundTransferDestinationPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
