// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class ConfigurationBbposWiseposE : StripeEntity<ConfigurationBbposWiseposE>
    {
        #region Expandable Splashscreen

        /// <summary>
        /// (ID of the File)
        /// A File ID representing an image you would like displayed on the reader.
        /// </summary>
        [JsonIgnore]
        public string SplashscreenId
        {
            get => this.InternalSplashscreen?.Id;
            set => this.InternalSplashscreen = SetExpandableFieldId(value, this.InternalSplashscreen);
        }

        /// <summary>
        /// (Expanded)
        /// A File ID representing an image you would like displayed on the reader.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File Splashscreen
        {
            get => this.InternalSplashscreen?.ExpandedObject;
            set => this.InternalSplashscreen = SetExpandableFieldObject(value, this.InternalSplashscreen);
        }

        [JsonPropertyName("splashscreen")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalSplashscreen { get; set; }
        #endregion
    }
}
