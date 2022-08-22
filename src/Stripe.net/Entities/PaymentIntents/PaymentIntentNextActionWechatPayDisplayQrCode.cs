// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionWechatPayDisplayQrCode : StripeEntity<PaymentIntentNextActionWechatPayDisplayQrCode>
    {
        /// <summary>
        /// The data being used to generate QR code.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// The base64 image data for a pre-generated QR code.
        /// </summary>
        [JsonPropertyName("image_data_url")]
        public string ImageDataUrl { get; set; }

        /// <summary>
        /// The image_url_png string used to render QR code.
        /// </summary>
        [JsonPropertyName("image_url_png")]
        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The image_url_svg string used to render QR code.
        /// </summary>
        [JsonPropertyName("image_url_svg")]
        public string ImageUrlSvg { get; set; }
    }
}
