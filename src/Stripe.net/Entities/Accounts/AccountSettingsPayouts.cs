// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsPayouts : StripeEntity<AccountSettingsPayouts>
    {
        /// <summary>
        /// A Boolean indicating if Stripe should try to reclaim negative balances from an attached
        /// bank account. See our <a
        /// href="https://stripe.com/docs/connect/account-balances">Understanding Connect Account
        /// Balances</a> documentation for details. Default value is <c>false</c> for Custom
        /// accounts, otherwise <c>true</c>.
        /// </summary>
        [JsonPropertyName("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonPropertyName("schedule")]
        public AccountSettingsPayoutsSchedule Schedule { get; set; }

        /// <summary>
        /// The text that appears on the bank account statement for payouts. If not set, this
        /// defaults to the platform's bank descriptor as set in the Dashboard.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
