// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderIndividualVerification : StripeEntity<CardholderIndividualVerification>
    {
        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonPropertyName("document")]
        public CardholderIndividualVerificationDocument Document { get; set; }
    }
}
