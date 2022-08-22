// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class AccountCardOptions : INestedOptions, IHasMetadata
    {
        [JsonPropertyName("object")]
        internal string Object => "card";

        [JsonPropertyName("address_city")]
        public string AddressCity { get; set; }

        [JsonPropertyName("address_country")]
        public string AddressCountry { get; set; }

        [JsonPropertyName("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonPropertyName("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonPropertyName("address_state")]
        public string AddressState { get; set; }

        [JsonPropertyName("address_zip")]
        public string AddressZip { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("cvc")]
        public string Cvc { get; set; }

        [JsonPropertyName("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
