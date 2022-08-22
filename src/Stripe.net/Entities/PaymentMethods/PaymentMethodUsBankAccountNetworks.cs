// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PaymentMethodUsBankAccountNetworks : StripeEntity<PaymentMethodUsBankAccountNetworks>
    {
        /// <summary>
        /// The preferred network.
        /// </summary>
        [JsonPropertyName("preferred")]
        public string Preferred { get; set; }

        /// <summary>
        /// All supported networks.
        /// </summary>
        [JsonPropertyName("supported")]
        public List<string> Supported { get; set; }
    }
}
