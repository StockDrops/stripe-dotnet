// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettings : StripeEntity<AccountSettings>
    {
        [JsonPropertyName("bacs_debit_payments")]
        public AccountSettingsBacsDebitPayments BacsDebitPayments { get; set; }

        [JsonPropertyName("branding")]
        public AccountSettingsBranding Branding { get; set; }

        [JsonPropertyName("card_issuing")]
        public AccountSettingsCardIssuing CardIssuing { get; set; }

        [JsonPropertyName("card_payments")]
        public AccountSettingsCardPayments CardPayments { get; set; }

        [JsonPropertyName("dashboard")]
        public AccountSettingsDashboard Dashboard { get; set; }

        [JsonPropertyName("payments")]
        public AccountSettingsPayments Payments { get; set; }

        [JsonPropertyName("payouts")]
        public AccountSettingsPayouts Payouts { get; set; }

        [JsonPropertyName("sepa_debit_payments")]
        public AccountSettingsSepaDebitPayments SepaDebitPayments { get; set; }

        [JsonPropertyName("treasury")]
        public AccountSettingsTreasury Treasury { get; set; }
    }
}
