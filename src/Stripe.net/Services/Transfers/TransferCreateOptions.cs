// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in cents (or local equivalent) representing how much to transfer.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 3-letter <a href="https://stripe.com/docs/payouts">ISO code for currency</a>.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of a connected Stripe account. &lt;a
        /// href="/docs/connect/charges-transfers"&gt;See the Connect documentation&lt;/a&gt; for
        /// details.
        /// </summary>
        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// You can use this parameter to transfer funds from a charge before they are added to your
        /// available balance. A pending balance will transfer immediately but the funds will not
        /// become available until the original charge becomes available. <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-availability">See the
        /// Connect documentation</a> for details.
        /// </summary>
        [JsonPropertyName("source_transaction")]
        public string SourceTransaction { get; set; }

        /// <summary>
        /// The source balance to use for this transfer. One of <c>bank_account</c>, <c>card</c>, or
        /// <c>fpx</c>. For most users, this will default to <c>card</c>.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
