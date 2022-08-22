// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsBacsDebitPayments : StripeEntity<AccountSettingsBacsDebitPayments>
    {
        /// <summary>
        /// The Bacs Direct Debit Display Name for this account. For payments made with Bacs Direct
        /// Debit, this will appear on the mandate, and as the statement descriptor.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }
    }
}
