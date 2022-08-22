// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerCashBalanceTransactionFundedBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransfer>
    {
        [JsonPropertyName("eu_bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransferEuBankTransfer EuBankTransfer { get; set; }

        /// <summary>
        /// The user-supplied reference field on the bank transfer.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The funding method type used to fund the customer balance. Permitted values include:
        /// <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>, or
        /// <c>mx_bank_transfer</c>.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>, or
        /// <c>mx_bank_transfer</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
