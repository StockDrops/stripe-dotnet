// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class DisputeEvidenceServiceNotAsDescribed : StripeEntity<DisputeEvidenceServiceNotAsDescribed>
    {
        #region Expandable AdditionalDocumentation

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonIgnore]
        public string AdditionalDocumentationId
        {
            get => this.InternalAdditionalDocumentation?.Id;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldId(value, this.InternalAdditionalDocumentation);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File AdditionalDocumentation
        {
            get => this.InternalAdditionalDocumentation?.ExpandedObject;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldObject(value, this.InternalAdditionalDocumentation);
        }

        [JsonPropertyName("additional_documentation")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        [JsonInclude]
        public ExpandableField<File> InternalAdditionalDocumentation { get; private set; }
        #endregion

        /// <summary>
        /// Date when order was canceled.
        /// </summary>
        [JsonPropertyName("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for canceling the order.
        /// </summary>
        [JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }

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
    }
}
