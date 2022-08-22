// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsTreasuryTosAcceptance : StripeEntity<AccountSettingsTreasuryTosAcceptance>
    {
        /// <summary>
        /// The Unix timestamp marking when the account representative accepted the service
        /// agreement.
        /// </summary>
        [JsonPropertyName("date")]
        public long? Date { get; set; }

        /// <summary>
        /// The IP address from which the account representative accepted the service agreement.
        /// </summary>
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the account representative accepted the service
        /// agreement.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
