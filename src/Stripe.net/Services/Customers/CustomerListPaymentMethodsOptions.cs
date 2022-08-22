// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CustomerListPaymentMethodsOptions : ListOptions
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
