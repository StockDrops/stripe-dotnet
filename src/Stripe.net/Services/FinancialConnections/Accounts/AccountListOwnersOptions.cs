// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Text.Json.Serialization;

    public class AccountListOwnersOptions : ListOptions
    {
        [JsonPropertyName("ownership")]
        public string Ownership { get; set; }
    }
}
