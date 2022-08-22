// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerCreateFundingInstructionsOptions : BaseOptions
    {
        /// <summary>
        /// Additional parameters for <c>bank_transfer</c> funding types.
        /// </summary>
        [JsonPropertyName("bank_transfer")]
        public CustomerBankTransferOptions BankTransfer { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The <c>funding_type</c> to get the instructions for.
        /// </summary>
        [JsonPropertyName("funding_type")]
        public string FundingType { get; set; }
    }
}
