// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Text.Json.Serialization;

    public class SessionPhoneNumberCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable phone number collection.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
