// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsAchDebit : StripeEntity<ChargePaymentMethodDetailsAchDebit>
    {
        /// <summary>
        /// Type of entity that holds the account. This can be either <c>individual</c> or
        /// <c>company</c>.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonPropertyName("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

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
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Routing transit number of the bank account.
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
