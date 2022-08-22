namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsDeclineOn : StripeEntity<AccountSettingsDeclineOn>
    {
        [JsonPropertyName("avs_failure")]
        public bool AvsFailure { get; set; }

        [JsonPropertyName("cvc_failure")]
        public bool CvcFailure { get; set; }
    }
}
