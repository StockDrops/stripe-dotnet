// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// If <c>true</c>, tax will be calculated automatically using the customer's location.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
