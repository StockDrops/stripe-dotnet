// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentAmountDetails : StripeEntity<PaymentIntentAmountDetails>
    {
        [JsonPropertyName("tip")]
        public PaymentIntentAmountDetailsTip Tip { get; set; }
    }
}
