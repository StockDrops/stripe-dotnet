// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Text.Json.Serialization;

    public class AccountAccountHolderOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose accounts will be retrieved.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Stripe customer whose accounts will be retrieved.
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }
    }
}
