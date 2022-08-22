// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Reason why the <c>status</c> of this card is <c>canceled</c>.
        /// One of: <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The desired new PIN for this card.
        /// </summary>
        [JsonPropertyName("pin")]
        public CardPinOptions Pin { get; set; }

        /// <summary>
        /// Rules that control spending for this card. Refer to our <a
        /// href="https://stripe.com/docs/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonPropertyName("spending_controls")]
        public CardSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Dictates whether authorizations can be approved on this card. If this card is being
        /// canceled because it was lost or stolen, this information should be provided as
        /// <c>cancellation_reason</c>.
        /// One of: <c>active</c>, <c>canceled</c>, or <c>inactive</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
