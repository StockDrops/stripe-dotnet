// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionPaymentSettingsPaymentMethodOptions : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options to pass to invoices created by the subscription.
        /// </summary>
        [JsonPropertyName("acss_debit")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonPropertyName("bancontact")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to invoices
        /// created by the subscription.
        /// </summary>
        [JsonPropertyName("card")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonPropertyName("customer_balance")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonPropertyName("konbini")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsKonbini Konbini { get; set; }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options to pass
        /// to invoices created by the subscription.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
