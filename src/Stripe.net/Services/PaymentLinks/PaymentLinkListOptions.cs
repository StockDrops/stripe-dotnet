// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkListOptions : ListOptions
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }
}
