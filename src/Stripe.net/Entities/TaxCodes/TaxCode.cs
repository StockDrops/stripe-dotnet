// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// <a href="https://stripe.com/docs/tax/tax-categories">Tax codes</a> classify goods and
    /// services for tax purposes.
    /// </summary>
    public class TaxCode : StripeEntity<TaxCode>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A detailed description of which types of products the tax code represents.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A short name for the tax code.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
