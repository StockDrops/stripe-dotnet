// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Set to true to enable automatic taxes.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
