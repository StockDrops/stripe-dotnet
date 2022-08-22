// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonPropertyName("alipay_handle_redirect")]
        public PaymentIntentNextActionAlipayHandleRedirect AlipayHandleRedirect { get; set; }

        [JsonPropertyName("boleto_display_details")]
        public PaymentIntentNextActionBoletoDisplayDetails BoletoDisplayDetails { get; set; }

        [JsonPropertyName("card_await_notification")]
        public PaymentIntentNextActionCardAwaitNotification CardAwaitNotification { get; set; }

        [JsonPropertyName("display_bank_transfer_instructions")]
        public PaymentIntentNextActionDisplayBankTransferInstructions DisplayBankTransferInstructions { get; set; }

        [JsonPropertyName("konbini_display_details")]
        public PaymentIntentNextActionKonbiniDisplayDetails KonbiniDisplayDetails { get; set; }

        [JsonPropertyName("oxxo_display_details")]
        public PaymentIntentNextActionOxxoDisplayDetails OxxoDisplayDetails { get; set; }

        [JsonPropertyName("paynow_display_qr_code")]
        public PaymentIntentNextActionPaynowDisplayQrCode PaynowDisplayQrCode { get; set; }

        [JsonPropertyName("promptpay_display_qr_code")]
        public PaymentIntentNextActionPromptpayDisplayQrCode PromptpayDisplayQrCode { get; set; }

        [JsonPropertyName("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, <c>oxxo_display_details</c>, or
        /// <c>verify_with_microdeposits</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("verify_with_microdeposits")]
        public PaymentIntentNextActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; set; }

        [JsonPropertyName("wechat_pay_display_qr_code")]
        public PaymentIntentNextActionWechatPayDisplayQrCode WechatPayDisplayQrCode { get; set; }

        [JsonPropertyName("wechat_pay_redirect_to_android_app")]
        public PaymentIntentNextActionWechatPayRedirectToAndroidApp WechatPayRedirectToAndroidApp { get; set; }

        [JsonPropertyName("wechat_pay_redirect_to_ios_app")]
        public PaymentIntentNextActionWechatPayRedirectToIosApp WechatPayRedirectToIosApp { get; set; }
    }
}
