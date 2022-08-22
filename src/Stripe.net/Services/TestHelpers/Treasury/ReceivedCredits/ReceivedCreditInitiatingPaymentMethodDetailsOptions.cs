// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditInitiatingPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The source type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Optional fields for <c>us_bank_account</c>.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public ReceivedCreditInitiatingPaymentMethodDetailsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
