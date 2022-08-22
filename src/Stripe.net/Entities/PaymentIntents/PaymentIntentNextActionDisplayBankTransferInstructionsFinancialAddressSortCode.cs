// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSortCode : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSortCode>
    {
        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The six-digit sort code.
        /// </summary>
        [JsonPropertyName("sort_code")]
        public string SortCode { get; set; }
    }
}
