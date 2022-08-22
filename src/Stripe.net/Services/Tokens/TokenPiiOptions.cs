// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TokenPiiOptions : INestedOptions
    {
        /// <summary>
        /// The <c>id_number</c> for the PII, in string form.
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }
    }
}
