// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class FundingInstructionsBankTransferFinancialAddressZengin : StripeEntity<FundingInstructionsBankTransferFinancialAddressZengin>
    {
        /// <summary>
        /// The account holder name.
        /// </summary>
        [JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The bank account type. In Japan, this can only be <c>futsu</c> or <c>toza</c>.
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// The bank code of the account.
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// The bank name of the account.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The branch code of the account.
        /// </summary>
        [JsonPropertyName("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// The branch name of the account.
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }
    }
}
