// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Text.Json.Serialization;

    public class ReceivedDebitInitiatingPaymentMethodDetailsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The bank account holder's name.
        /// </summary>
        [JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The bank account number.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The bank account's routing number.
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
