// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsAchCreditTransfer : StripeEntity<ChargePaymentMethodDetailsAchCreditTransfer>
    {
        /// <summary>
        /// Account number to transfer funds to.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Name of the bank associated with the routing number.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Routing transit number for the bank account to transfer funds to.
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// SWIFT code of the bank associated with the routing number.
        /// </summary>
        [JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
