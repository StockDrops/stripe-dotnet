// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentPaymentMethodDataAcssDebitOptions : INestedOptions
    {
        /// <summary>
        /// Customer's bank account number.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Institution number of the customer's bank.
        /// </summary>
        [JsonPropertyName("institution_number")]
        public string InstitutionNumber { get; set; }

        /// <summary>
        /// Transit number of the customer's bank.
        /// </summary>
        [JsonPropertyName("transit_number")]
        public string TransitNumber { get; set; }
    }
}
