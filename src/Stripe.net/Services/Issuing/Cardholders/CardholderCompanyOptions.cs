// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderCompanyOptions : INestedOptions
    {
        /// <summary>
        /// The entity's business ID number.
        /// </summary>
        [JsonPropertyName("tax_id")]
        public string TaxId { get; set; }
    }
}
