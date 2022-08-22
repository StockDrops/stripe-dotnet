namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonPropertyName("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonPropertyName("validate")]
        public bool? Validate { get; set; }
    }
}
