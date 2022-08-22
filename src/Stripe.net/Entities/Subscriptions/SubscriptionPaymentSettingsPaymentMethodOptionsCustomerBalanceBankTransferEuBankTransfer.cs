// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer>
    {
        /// <summary>
        /// The desired country code of the bank account information. Permitted values include:
        /// <c>DE</c>, <c>ES</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// One of: <c>DE</c>, <c>ES</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
