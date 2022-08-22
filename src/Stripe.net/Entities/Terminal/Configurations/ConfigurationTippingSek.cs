// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ConfigurationTippingSek : StripeEntity<ConfigurationTippingSek>
    {
        /// <summary>
        /// Fixed amounts displayed when collecting a tip.
        /// </summary>
        [JsonPropertyName("fixed_amounts")]
        public List<long> FixedAmounts { get; set; }

        /// <summary>
        /// Percentages displayed when collecting a tip.
        /// </summary>
        [JsonPropertyName("percentages")]
        public List<long> Percentages { get; set; }

        /// <summary>
        /// Below this amount, fixed amounts will be displayed; above it, percentages will be
        /// displayed.
        /// </summary>
        [JsonPropertyName("smart_tip_threshold")]
        public long SmartTipThreshold { get; set; }
    }
}
