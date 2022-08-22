// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionTaxIdCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Set to true to enable Tax ID collection.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
