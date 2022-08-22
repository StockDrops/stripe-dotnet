// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerCashBalanceTransactionFunded : StripeEntity<CustomerCashBalanceTransactionFunded>
    {
        [JsonPropertyName("bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransfer BankTransfer { get; set; }
    }
}
