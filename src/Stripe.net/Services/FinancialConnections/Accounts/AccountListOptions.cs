// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Text.Json.Serialization;

    public class AccountListOptions : ListOptions
    {
        [JsonPropertyName("account_holder")]
        public AccountAccountHolderOptions AccountHolder { get; set; }

        [JsonPropertyName("session")]
        public string Session { get; set; }
    }
}
