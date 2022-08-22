// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsCardIssuing : StripeEntity<AccountSettingsCardIssuing>
    {
        [JsonPropertyName("tos_acceptance")]
        public AccountSettingsCardIssuingTosAcceptance TosAcceptance { get; set; }
    }
}
