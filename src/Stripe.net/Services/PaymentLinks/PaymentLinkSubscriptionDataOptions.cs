// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkSubscriptionDataOptions : INestedOptions
    {
        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time. Has to be at least 1.
        /// </summary>
        [JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
