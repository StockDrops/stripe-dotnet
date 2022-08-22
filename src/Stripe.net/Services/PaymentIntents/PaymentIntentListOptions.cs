// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("customer")]
        public string Customer { get; set; }
    }
}
