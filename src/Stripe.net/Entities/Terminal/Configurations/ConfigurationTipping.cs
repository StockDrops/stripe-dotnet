// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ConfigurationTipping : StripeEntity<ConfigurationTipping>
    {
        [JsonPropertyName("aud")]
        public ConfigurationTippingAud Aud { get; set; }

        [JsonPropertyName("cad")]
        public ConfigurationTippingCad Cad { get; set; }

        [JsonPropertyName("chf")]
        public ConfigurationTippingChf Chf { get; set; }

        [JsonPropertyName("czk")]
        public ConfigurationTippingCzk Czk { get; set; }

        [JsonPropertyName("dkk")]
        public ConfigurationTippingDkk Dkk { get; set; }

        [JsonPropertyName("eur")]
        public ConfigurationTippingEur Eur { get; set; }

        [JsonPropertyName("gbp")]
        public ConfigurationTippingGbp Gbp { get; set; }

        [JsonPropertyName("hkd")]
        public ConfigurationTippingHkd Hkd { get; set; }

        [JsonPropertyName("myr")]
        public ConfigurationTippingMyr Myr { get; set; }

        [JsonPropertyName("nok")]
        public ConfigurationTippingNok Nok { get; set; }

        [JsonPropertyName("nzd")]
        public ConfigurationTippingNzd Nzd { get; set; }

        [JsonPropertyName("sek")]
        public ConfigurationTippingSek Sek { get; set; }

        [JsonPropertyName("sgd")]
        public ConfigurationTippingSgd Sgd { get; set; }

        [JsonPropertyName("usd")]
        public ConfigurationTippingUsd Usd { get; set; }
    }
}
