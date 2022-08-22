// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkTaxIdCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable tax ID collection.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
