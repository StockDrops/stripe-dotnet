// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsSepaDebitPayments : StripeEntity<AccountSettingsSepaDebitPayments>
    {
        /// <summary>
        /// SEPA creditor identifier that identifies the company making the payment.
        /// </summary>
        [JsonPropertyName("creditor_id")]
        public string CreditorId { get; set; }
    }
}
