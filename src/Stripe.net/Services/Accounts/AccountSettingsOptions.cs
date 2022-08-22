// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings used to apply the account's branding to email receipts, invoices, Checkout, and
        /// other products.
        /// </summary>
        [JsonPropertyName("branding")]
        public AccountSettingsBrandingOptions Branding { get; set; }

        /// <summary>
        /// Settings specific to the account's use of the Card Issuing product.
        /// </summary>
        [JsonPropertyName("card_issuing")]
        public AccountSettingsCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// Settings specific to card charging on the account.
        /// </summary>
        [JsonPropertyName("card_payments")]
        public AccountSettingsCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Settings that apply across payment methods for charging on the account.
        /// </summary>
        [JsonPropertyName("payments")]
        public AccountSettingsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Settings specific to the account's payouts.
        /// </summary>
        [JsonPropertyName("payouts")]
        public AccountSettingsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Settings specific to the account's Treasury FinancialAccounts.
        /// </summary>
        [JsonPropertyName("treasury")]
        public AccountSettingsTreasuryOptions Treasury { get; set; }
    }
}
