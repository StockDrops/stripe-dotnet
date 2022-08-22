// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderBilling : StripeEntity<CardholderBilling>
    {
        [JsonPropertyName("address")]
        public Address Address { get; set; }
    }
}
