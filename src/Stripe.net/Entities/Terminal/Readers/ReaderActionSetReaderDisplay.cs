// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderActionSetReaderDisplay : StripeEntity<ReaderActionSetReaderDisplay>
    {
        /// <summary>
        /// Cart object to be displayed by the reader.
        /// </summary>
        [JsonPropertyName("cart")]
        public ReaderActionSetReaderDisplayCart Cart { get; set; }

        /// <summary>
        /// Type of information to be displayed by the reader.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
