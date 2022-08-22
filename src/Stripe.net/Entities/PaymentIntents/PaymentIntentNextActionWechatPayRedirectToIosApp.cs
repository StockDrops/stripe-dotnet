// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionWechatPayRedirectToIosApp : StripeEntity<PaymentIntentNextActionWechatPayRedirectToIosApp>
    {
        /// <summary>
        /// An universal link that redirect to WeChat Pay app.
        /// </summary>
        [JsonPropertyName("native_url")]
        public string NativeUrl { get; set; }
    }
}
