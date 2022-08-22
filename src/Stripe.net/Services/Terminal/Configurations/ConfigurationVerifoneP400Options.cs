// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ConfigurationVerifoneP400Options : INestedOptions
    {
        /// <summary>
        /// A File ID representing an image you would like displayed on the reader.
        /// </summary>
        [JsonPropertyName("splashscreen")]
        public string Splashscreen { get; set; }
    }
}
