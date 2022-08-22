// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderIndividualVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonPropertyName("back")]
        public string Back { get; set; }

        /// <summary>
        /// The front of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonPropertyName("front")]
        public string Front { get; set; }
    }
}
