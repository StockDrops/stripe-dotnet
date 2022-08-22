// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsSepaDebit : StripeEntity<ChargePaymentMethodDetailsSepaDebit>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Branch code of bank associated with the bank account.
        /// </summary>
        [JsonPropertyName("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonPropertyName("mandate")]
        public string Mandate { get; set; }
    }
}
