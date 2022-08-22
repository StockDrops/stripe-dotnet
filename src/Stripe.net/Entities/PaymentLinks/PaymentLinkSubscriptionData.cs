// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkSubscriptionData : StripeEntity<PaymentLinkSubscriptionData>
    {
        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
