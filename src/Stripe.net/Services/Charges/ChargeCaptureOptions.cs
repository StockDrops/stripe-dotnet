// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargeCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture, which must be less than or equal to the original amount. Any
        /// additional amount will be automatically refunded.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// An application fee to add on to this charge.
        /// </summary>
        [JsonPropertyName("application_fee")]
        public long? ApplicationFee { get; set; }

        /// <summary>
        /// An application fee amount to add on to this charge, which must be less than or equal to
        /// the original amount.
        /// </summary>
        [JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonPropertyName("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The email address to send this charge's receipt to. This will override the
        /// previously-specified email address for this charge, if one was set. Receipts will not be
        /// sent in test mode.
        /// </summary>
        [JsonPropertyName("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// For card charges, use <c>statement_descriptor_suffix</c> instead. Otherwise, you can use
        /// this value as the complete description of a charge on your customers’ statements. Must
        /// contain at least one letter, maximum 22 characters.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonPropertyName("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge. <a href="https://stripe.com/docs/connect/destination-charges">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonPropertyName("transfer_data")]
        public ChargeTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. <c>transfer_group</c> may
        /// only be provided if it has not been set. See the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
