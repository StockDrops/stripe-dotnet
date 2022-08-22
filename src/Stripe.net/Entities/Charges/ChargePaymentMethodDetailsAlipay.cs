// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsAlipay : StripeEntity<ChargePaymentMethodDetailsAlipay>
    {
        /// <summary>
        /// Uniquely identifies this particular Alipay account. You can use this attribute to check
        /// whether two Alipay accounts are the same.
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// Uniquely identifies this particular Alipay account. You can use this attribute to check
        /// whether two Alipay accounts are the same.
        /// </summary>
        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Transaction ID of this particular Alipay transaction.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
