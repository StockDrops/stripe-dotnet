// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsTreasury : StripeEntity<AccountSettingsTreasury>
    {
        [JsonPropertyName("tos_acceptance")]
        public AccountSettingsTreasuryTosAcceptance TosAcceptance { get; set; }
    }
}
