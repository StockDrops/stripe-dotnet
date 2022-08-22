// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class FundingInstructionsBankTransferFinancialAddressSpei : StripeEntity<FundingInstructionsBankTransferFinancialAddressSpei>
    {
        /// <summary>
        /// The three-digit bank code.
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// The short banking institution name.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The CLABE number.
        /// </summary>
        [JsonPropertyName("clabe")]
        public string Clabe { get; set; }
    }
}
