// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class CardholderIndividualVerificationDocument : StripeEntity<CardholderIndividualVerificationDocument>
    {
        #region Expandable Back

        /// <summary>
        /// (ID of the File)
        /// The back of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public string BackId
        {
            get => this.InternalBack?.Id;
            set => this.InternalBack = SetExpandableFieldId(value, this.InternalBack);
        }

        /// <summary>
        /// (Expanded)
        /// The back of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File Back
        {
            get => this.InternalBack?.ExpandedObject;
            set => this.InternalBack = SetExpandableFieldObject(value, this.InternalBack);
        }

        [JsonPropertyName("back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        [JsonInclude]
        public ExpandableField<File> InternalBack { get; private set; }
        #endregion

        #region Expandable Front

        /// <summary>
        /// (ID of the File)
        /// The front of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public string FrontId
        {
            get => this.InternalFront?.Id;
            set => this.InternalFront = SetExpandableFieldId(value, this.InternalFront);
        }

        /// <summary>
        /// (Expanded)
        /// The front of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File Front
        {
            get => this.InternalFront?.ExpandedObject;
            set => this.InternalFront = SetExpandableFieldObject(value, this.InternalFront);
        }

        [JsonPropertyName("front")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        [JsonInclude]
        public ExpandableField<File> InternalFront { get; private set; }
        #endregion
    }
}
