// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsWechatPay : StripeEntity<ChargePaymentMethodDetailsWechatPay>
    {
        /// <summary>
        /// Uniquely identifies this particular WeChat Pay account. You can use this attribute to
        /// check whether two WeChat accounts are the same.
        /// </summary>
        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Transaction ID of this particular WeChat Pay transaction.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
