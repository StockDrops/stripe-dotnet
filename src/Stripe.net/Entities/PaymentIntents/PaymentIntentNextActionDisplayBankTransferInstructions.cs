// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionDisplayBankTransferInstructions : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructions>
    {
        /// <summary>
        /// The remaining amount that needs to be transferred to complete the payment.
        /// </summary>
        [JsonPropertyName("amount_remaining")]
        public long? AmountRemaining { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A list of financial addresses that can be used to fund the customer balance.
        /// </summary>
        [JsonPropertyName("financial_addresses")]
        public List<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddress> FinancialAddresses { get; set; }

        /// <summary>
        /// A link to a hosted page that guides your customer through completing the transfer.
        /// </summary>
        [JsonPropertyName("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// A string identifying this payment. Instruct your customer to include this code in the
        /// reference or memo field of their bank transfer.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Type of bank transfer.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>, or
        /// <c>mx_bank_transfer</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
