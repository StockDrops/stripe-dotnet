// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderCompany : StripeEntity<CardholderCompany>
    {
        /// <summary>
        /// Whether the company's business ID number was provided.
        /// </summary>
        [JsonPropertyName("tax_id_provided")]
        public bool TaxIdProvided { get; set; }
    }
}
