// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsCardWallet : StripeEntity<ChargePaymentMethodDetailsCardWallet>
    {
        [JsonPropertyName("amex_express_checkout")]
        public ChargePaymentMethodDetailsCardWalletAmexExpressCheckout AmexExpressCheckout { get; set; }

        [JsonPropertyName("apple_pay")]
        public ChargePaymentMethodDetailsCardWalletApplePay ApplePay { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonPropertyName("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonPropertyName("google_pay")]
        public ChargePaymentMethodDetailsCardWalletGooglePay GooglePay { get; set; }

        [JsonPropertyName("masterpass")]
        public ChargePaymentMethodDetailsCardWalletMasterpass Masterpass { get; set; }

        [JsonPropertyName("samsung_pay")]
        public ChargePaymentMethodDetailsCardWalletSamsungPay SamsungPay { get; set; }

        /// <summary>
        /// The type of the card wallet, one of <c>amex_express_checkout</c>, <c>apple_pay</c>,
        /// <c>google_pay</c>, <c>masterpass</c>, <c>samsung_pay</c>, or <c>visa_checkout</c>. An
        /// additional hash is included on the Wallet subhash with a name matching this value. It
        /// contains additional information specific to the card wallet type.
        /// One of: <c>amex_express_checkout</c>, <c>apple_pay</c>, <c>google_pay</c>,
        /// <c>masterpass</c>, <c>samsung_pay</c>, or <c>visa_checkout</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("visa_checkout")]
        public ChargePaymentMethodDetailsCardWalletVisaCheckout VisaCheckout { get; set; }
    }
}
