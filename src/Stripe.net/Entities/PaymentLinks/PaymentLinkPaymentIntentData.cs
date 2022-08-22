// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkPaymentIntentData : StripeEntity<PaymentLinkPaymentIntentData>
    {
        /// <summary>
        /// Indicates when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with the payment method collected
        /// during checkout.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
