// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceRedirectOptions : INestedOptions
    {
        /// <summary>
        /// The URL you provide to redirect the customer back to you after they authenticated their
        /// payment. It can use your application URI scheme in the context of a mobile application.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
