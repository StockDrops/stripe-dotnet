// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderCardPresentOptions : INestedOptions
    {
        /// <summary>
        /// Card Number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
