// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance>
    {
        [JsonPropertyName("bank_transfer")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// The funding method type to be used when there are not enough funds in the customer
        /// balance. Permitted values include: <c>bank_transfer</c>.
        /// </summary>
        [JsonPropertyName("funding_type")]
        public string FundingType { get; set; }
    }
}
