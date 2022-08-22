// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionScheduleReleaseOptions : BaseOptions
    {
        /// <summary>
        /// Keep any cancellation on the subscription that the schedule has set.
        /// </summary>
        [JsonPropertyName("preserve_cancel_date")]
        public bool? PreserveCancelDate { get; set; }
    }
}
