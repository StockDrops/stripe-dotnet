// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer>
    {
        [JsonPropertyName("eu_bank_transfer")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer EuBankTransfer { get; set; }

        /// <summary>
        /// The bank transfer type that can be used for funding. Permitted values include:
        /// <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>, or
        /// <c>mx_bank_transfer</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
