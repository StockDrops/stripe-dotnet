// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class DisputeEvidenceMerchandiseNotAsDescribedOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonPropertyName("additional_documentation")]
        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Date when the product was received.
        /// </summary>
        [JsonPropertyName("received_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// Description of the cardholder's attempt to return the product.
        /// </summary>
        [JsonPropertyName("return_description")]
        public string ReturnDescription { get; set; }

        /// <summary>
        /// Result of cardholder's attempt to return the product.
        /// </summary>
        [JsonPropertyName("return_status")]
        public string ReturnStatus { get; set; }

        /// <summary>
        /// Date when the product was returned or attempted to be returned.
        /// </summary>
        [JsonPropertyName("returned_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReturnedAt { get; set; }
    }
}
