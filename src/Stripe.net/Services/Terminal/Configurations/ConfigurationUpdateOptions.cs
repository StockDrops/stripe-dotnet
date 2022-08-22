// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ConfigurationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// An object containing device type specific settings for BBPOS WisePOS E readers.
        /// </summary>
        [JsonPropertyName("bbpos_wisepos_e")]
        public ConfigurationBbposWiseposEOptions BbposWiseposE { get; set; }

        /// <summary>
        /// Tipping configurations for readers supporting on-reader tips.
        /// </summary>
        [JsonPropertyName("tipping")]
        public ConfigurationTippingOptions Tipping { get; set; }

        /// <summary>
        /// An object containing device type specific settings for Verifone P400 readers.
        /// </summary>
        [JsonPropertyName("verifone_p400")]
        public ConfigurationVerifoneP400Options VerifoneP400 { get; set; }
    }
}
