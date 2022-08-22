// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class RefundCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer representing how much to refund.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Customer whose customer balance to refund from.
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Address to send refund email, use customer email if not specified.
        /// </summary>
        [JsonPropertyName("instructions_email")]
        public string InstructionsEmail { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Origin of the refund.
        /// </summary>
        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        [JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        [JsonPropertyName("reverse_transfer")]
        public bool? ReverseTransfer { get; set; }
    }
}
