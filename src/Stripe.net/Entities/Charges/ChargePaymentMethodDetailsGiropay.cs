// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsGiropay : StripeEntity<ChargePaymentMethodDetailsGiropay>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Bank Identifier Code of the bank associated with the bank account.
        /// </summary>
        [JsonPropertyName("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by Giropay directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// Giropay rarely provides this information so the attribute is usually empty.
        /// </summary>
        [JsonPropertyName("verified_name")]
        public string VerifiedName { get; set; }
    }
}
