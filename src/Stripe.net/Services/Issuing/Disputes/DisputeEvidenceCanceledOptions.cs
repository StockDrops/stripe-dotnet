// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class DisputeEvidenceCanceledOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonPropertyName("additional_documentation")]
        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// Date when order was canceled.
        /// </summary>
        [JsonPropertyName("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Whether the cardholder was provided with a cancellation policy.
        /// </summary>
        [JsonPropertyName("cancellation_policy_provided")]
        public bool? CancellationPolicyProvided { get; set; }

        /// <summary>
        /// Reason for canceling the order.
        /// </summary>
        [JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Date when the cardholder expected to receive the product.
        /// </summary>
        [JsonPropertyName("expected_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpectedAt { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Description of the merchandise or service that was purchased.
        /// </summary>
        [JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Whether the product was a merchandise or service.
        /// </summary>
        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

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
