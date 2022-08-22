// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class TokenCvcUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The CVC value, in string form.
        /// </summary>
        [JsonPropertyName("cvc")]
        public string Cvc { get; set; }
    }
}
