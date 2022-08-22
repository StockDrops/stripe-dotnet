// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodDataAuBecsDebitOptions : INestedOptions
    {
        /// <summary>
        /// The account number for the bank account.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonPropertyName("bsb_number")]
        public string BsbNumber { get; set; }
    }
}
