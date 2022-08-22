// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class ReaderActionProcessSetupIntent : StripeEntity<ReaderActionProcessSetupIntent>
    {
        [JsonPropertyName("generated_card")]
        public string GeneratedCard { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// Most recent SetupIntent processed by the reader.
        /// </summary>
        [JsonIgnore]
        public string SetupIntentId
        {
            get => this.InternalSetupIntent?.Id;
            set => this.InternalSetupIntent = SetExpandableFieldId(value, this.InternalSetupIntent);
        }

        /// <summary>
        /// (Expanded)
        /// Most recent SetupIntent processed by the reader.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonPropertyName("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        [JsonInclude]
        public ExpandableField<SetupIntent> InternalSetupIntent { get; private set; }
        #endregion
    }
}
