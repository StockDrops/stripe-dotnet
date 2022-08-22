// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoiceCustomFieldOptions : INestedOptions
    {
        /// <summary>
        /// The name of the custom field. This may be up to 30 characters.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the custom field. This may be up to 30 characters.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
