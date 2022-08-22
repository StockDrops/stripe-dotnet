// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CashBalanceUpdateOptions : BaseOptions
    {
        /// <summary>
        /// A hash of settings for this cash balance.
        /// </summary>
        [JsonPropertyName("settings")]
        public CashBalanceSettingsOptions Settings { get; set; }
    }
}
