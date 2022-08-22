// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedCreditInitiatingPaymentMethodDetailsUsBankAccount : StripeEntity<ReceivedCreditInitiatingPaymentMethodDetailsUsBankAccount>
    {
        /// <summary>
        /// Bank name.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The last four digits of the bank account number.
        /// </summary>
        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The routing number for the bank account.
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
