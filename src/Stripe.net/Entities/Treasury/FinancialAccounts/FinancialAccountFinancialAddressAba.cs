// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class FinancialAccountFinancialAddressAba : StripeEntity<FinancialAccountFinancialAddressAba>
    {
        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The last four characters of the account number.
        /// </summary>
        [JsonPropertyName("account_number_last4")]
        public string AccountNumberLast4 { get; set; }

        /// <summary>
        /// Name of the bank.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Routing number for the account.
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
