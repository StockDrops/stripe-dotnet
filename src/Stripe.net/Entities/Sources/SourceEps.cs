// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceEps : StripeEntity<SourceEps>
    {
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
