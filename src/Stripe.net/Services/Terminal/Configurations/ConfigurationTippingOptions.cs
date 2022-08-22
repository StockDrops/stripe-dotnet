// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ConfigurationTippingOptions : INestedOptions
    {
        /// <summary>
        /// Tipping configuration for AUD.
        /// </summary>
        [JsonPropertyName("aud")]
        public ConfigurationTippingAudOptions Aud { get; set; }

        /// <summary>
        /// Tipping configuration for CAD.
        /// </summary>
        [JsonPropertyName("cad")]
        public ConfigurationTippingCadOptions Cad { get; set; }

        /// <summary>
        /// Tipping configuration for CHF.
        /// </summary>
        [JsonPropertyName("chf")]
        public ConfigurationTippingChfOptions Chf { get; set; }

        /// <summary>
        /// Tipping configuration for CZK.
        /// </summary>
        [JsonPropertyName("czk")]
        public ConfigurationTippingCzkOptions Czk { get; set; }

        /// <summary>
        /// Tipping configuration for DKK.
        /// </summary>
        [JsonPropertyName("dkk")]
        public ConfigurationTippingDkkOptions Dkk { get; set; }

        /// <summary>
        /// Tipping configuration for EUR.
        /// </summary>
        [JsonPropertyName("eur")]
        public ConfigurationTippingEurOptions Eur { get; set; }

        /// <summary>
        /// Tipping configuration for GBP.
        /// </summary>
        [JsonPropertyName("gbp")]
        public ConfigurationTippingGbpOptions Gbp { get; set; }

        /// <summary>
        /// Tipping configuration for HKD.
        /// </summary>
        [JsonPropertyName("hkd")]
        public ConfigurationTippingHkdOptions Hkd { get; set; }

        /// <summary>
        /// Tipping configuration for MYR.
        /// </summary>
        [JsonPropertyName("myr")]
        public ConfigurationTippingMyrOptions Myr { get; set; }

        /// <summary>
        /// Tipping configuration for NOK.
        /// </summary>
        [JsonPropertyName("nok")]
        public ConfigurationTippingNokOptions Nok { get; set; }

        /// <summary>
        /// Tipping configuration for NZD.
        /// </summary>
        [JsonPropertyName("nzd")]
        public ConfigurationTippingNzdOptions Nzd { get; set; }

        /// <summary>
        /// Tipping configuration for SEK.
        /// </summary>
        [JsonPropertyName("sek")]
        public ConfigurationTippingSekOptions Sek { get; set; }

        /// <summary>
        /// Tipping configuration for SGD.
        /// </summary>
        [JsonPropertyName("sgd")]
        public ConfigurationTippingSgdOptions Sgd { get; set; }

        /// <summary>
        /// Tipping configuration for USD.
        /// </summary>
        [JsonPropertyName("usd")]
        public ConfigurationTippingUsdOptions Usd { get; set; }
    }
}
