// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceP24 : StripeEntity<SourceP24>
    {
        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
