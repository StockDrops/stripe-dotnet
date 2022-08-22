// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderBillingOptions : INestedOptions
    {
        /// <summary>
        /// The cardholder’s billing address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressOptions Address { get; set; }
    }
}
