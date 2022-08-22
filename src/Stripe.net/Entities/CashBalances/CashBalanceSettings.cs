// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CashBalanceSettings : StripeEntity<CashBalanceSettings>
    {
        /// <summary>
        /// The configuration for how funds that land in the customer cash balance are reconciled.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonPropertyName("reconciliation_mode")]
        public string ReconciliationMode { get; set; }
    }
}
