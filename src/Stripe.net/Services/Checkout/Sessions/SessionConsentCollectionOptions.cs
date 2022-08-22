// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionConsentCollectionOptions : INestedOptions
    {
        /// <summary>
        /// If set to <c>auto</c>, enables the collection of customer consent for promotional
        /// communications. The Checkout Session will determine whether to display an option to opt
        /// into promotional communication from the merchant depending on the customer's locale.
        /// Only available to US merchants.
        /// One of: <c>auto</c>, or <c>none</c>.
        /// </summary>
        [JsonPropertyName("promotions")]
        public string Promotions { get; set; }
    }
}
