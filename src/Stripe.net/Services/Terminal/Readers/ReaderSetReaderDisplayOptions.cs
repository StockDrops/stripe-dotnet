// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderSetReaderDisplayOptions : BaseOptions
    {
        /// <summary>
        /// Cart.
        /// </summary>
        [JsonPropertyName("cart")]
        public ReaderCartOptions Cart { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
