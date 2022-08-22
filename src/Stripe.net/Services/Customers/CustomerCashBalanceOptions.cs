// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerCashBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Settings controlling the behavior of the customer's cash balance, such as reconciliation
        /// of funds received.
        /// </summary>
        [JsonPropertyName("settings")]
        public CustomerCashBalanceSettingsOptions Settings { get; set; }
    }
}
