// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentProcessingCard : StripeEntity<PaymentIntentProcessingCard>
    {
        [JsonPropertyName("customer_notification")]
        public PaymentIntentProcessingCardCustomerNotification CustomerNotification { get; set; }
    }
}
