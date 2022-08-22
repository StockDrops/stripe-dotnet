// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FundingInstructionsBankTransferFinancialAddress : StripeEntity<FundingInstructionsBankTransferFinancialAddress>
    {
        /// <summary>
        /// Iban Records contain E.U. bank account details per the SEPA format.
        /// </summary>
        [JsonPropertyName("iban")]
        public FundingInstructionsBankTransferFinancialAddressIban Iban { get; set; }

        /// <summary>
        /// Sort Code Records contain U.K. bank account details per the sort code format.
        /// </summary>
        [JsonPropertyName("sort_code")]
        public FundingInstructionsBankTransferFinancialAddressSortCode SortCode { get; set; }

        /// <summary>
        /// SPEI Records contain Mexico bank account details per the SPEI format.
        /// </summary>
        [JsonPropertyName("spei")]
        public FundingInstructionsBankTransferFinancialAddressSpei Spei { get; set; }

        /// <summary>
        /// The payment networks supported by this FinancialAddress.
        /// </summary>
        [JsonPropertyName("supported_networks")]
        public List<string> SupportedNetworks { get; set; }

        /// <summary>
        /// The type of financial address.
        /// One of: <c>iban</c>, <c>sort_code</c>, <c>spei</c>, or <c>zengin</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Zengin Records contain Japan bank account details per the Zengin format.
        /// </summary>
        [JsonPropertyName("zengin")]
        public FundingInstructionsBankTransferFinancialAddressZengin Zengin { get; set; }
    }
}
