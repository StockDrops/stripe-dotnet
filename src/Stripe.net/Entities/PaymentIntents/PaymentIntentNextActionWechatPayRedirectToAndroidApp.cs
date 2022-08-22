// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionWechatPayRedirectToAndroidApp : StripeEntity<PaymentIntentNextActionWechatPayRedirectToAndroidApp>
    {
        /// <summary>
        /// app_id is the APP ID registered on WeChat open platform.
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// nonce_str is a random string.
        /// </summary>
        [JsonPropertyName("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// package is static value.
        /// </summary>
        [JsonPropertyName("package")]
        public string Package { get; set; }

        /// <summary>
        /// an unique merchant ID assigned by WeChat Pay.
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// an unique trading ID assigned by WeChat Pay.
        /// </summary>
        [JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }

        /// <summary>
        /// A signature.
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// Specifies the current time in epoch format.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}
