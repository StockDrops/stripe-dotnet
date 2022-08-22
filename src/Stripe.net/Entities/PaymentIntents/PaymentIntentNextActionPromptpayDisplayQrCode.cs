// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionPromptpayDisplayQrCode : StripeEntity<PaymentIntentNextActionPromptpayDisplayQrCode>
    {
        /// <summary>
        /// The raw data string used to generate QR code, it should be used together with QR code
        /// library.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// The URL to the hosted PromptPay instructions page, which allows customers to view the
        /// PromptPay QR code.
        /// </summary>
        [JsonPropertyName("hosted_instructions_url")]
        public string HostedInstructionsUrl { get; set; }

        /// <summary>
        /// The image_url_png string used to render QR code, can be used as &lt;img src="…" /&gt;.
        /// </summary>
        [JsonPropertyName("image_url_png")]
        public string ImageUrlPng { get; set; }

        /// <summary>
        /// The image_url_svg string used to render QR code, can be used as &lt;img src="…" /&gt;.
        /// </summary>
        [JsonPropertyName("image_url_svg")]
        public string ImageUrlSvg { get; set; }
    }
}
