// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodAcssDebit : StripeEntity<PaymentMethodAcssDebit>
    {
        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Institution number of the bank account.
        /// </summary>
        [JsonPropertyName("institution_number")]
        public string InstitutionNumber { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Transit number of the bank account.
        /// </summary>
        [JsonPropertyName("transit_number")]
        public string TransitNumber { get; set; }
    }
}
