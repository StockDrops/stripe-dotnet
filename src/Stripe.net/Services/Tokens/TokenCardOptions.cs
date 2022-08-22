// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TokenCardOptions : INestedOptions
    {
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

        [JsonPropertyName("exp_month")]
        public string ExpMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public string ExpYear { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
