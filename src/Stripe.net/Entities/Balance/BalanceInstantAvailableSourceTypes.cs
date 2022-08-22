// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class BalanceInstantAvailableSourceTypes : StripeEntity<BalanceInstantAvailableSourceTypes>
    {
        /// <summary>
        /// Amount for bank account.
        /// </summary>
        [JsonPropertyName("bank_account")]
        public long BankAccount { get; set; }

        /// <summary>
        /// Amount for card.
        /// </summary>
        [JsonPropertyName("card")]
        public long Card { get; set; }

        /// <summary>
        /// Amount for FPX.
        /// </summary>
        [JsonPropertyName("fpx")]
        public long Fpx { get; set; }
    }
}
