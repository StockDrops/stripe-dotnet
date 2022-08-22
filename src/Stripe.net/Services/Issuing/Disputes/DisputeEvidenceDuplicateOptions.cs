// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class DisputeEvidenceDuplicateOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonPropertyName("additional_documentation")]
        public string AdditionalDocumentation { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the card statement showing that the product had already been paid for.
        /// </summary>
        [JsonPropertyName("card_statement")]
        public string CardStatement { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Copy of
        /// the receipt showing that the product had been paid for in cash.
        /// </summary>
        [JsonPropertyName("cash_receipt")]
        public string CashReceipt { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Image of
        /// the front and back of the check that was used to pay for the product.
        /// </summary>
        [JsonPropertyName("check_image")]
        public string CheckImage { get; set; }

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Transaction (e.g., ipi_...) that the disputed transaction is a duplicate of. Of the two
        /// or more transactions that are copies of each other, this is original undisputed one.
        /// </summary>
        [JsonPropertyName("original_transaction")]
        public string OriginalTransaction { get; set; }
    }
}
