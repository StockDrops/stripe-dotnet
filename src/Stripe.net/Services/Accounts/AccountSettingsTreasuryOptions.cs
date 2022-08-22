// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsTreasuryOptions : INestedOptions
    {
        /// <summary>
        /// Details on the account's acceptance of the Stripe Treasury Services Agreement.
        /// </summary>
        [JsonPropertyName("tos_acceptance")]
        public AccountSettingsTreasuryTosAcceptanceOptions TosAcceptance { get; set; }
    }
}
