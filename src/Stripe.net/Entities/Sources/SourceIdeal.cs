// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceIdeal : StripeEntity<SourceIdeal>
    {
        [JsonPropertyName("bank")]
        public string Bank { get; set; }

        [JsonPropertyName("bic")]
        public string Bic { get; set; }

        [JsonPropertyName("iban_last4")]
        public string IbanLast4 { get; set; }

        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
