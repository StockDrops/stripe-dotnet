// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardPinOptions : INestedOptions
    {
        /// <summary>
        /// The card's desired new PIN, encrypted under Stripe's public key.
        /// </summary>
        [JsonPropertyName("encrypted_number")]
        public string EncryptedNumber { get; set; }
    }
}
