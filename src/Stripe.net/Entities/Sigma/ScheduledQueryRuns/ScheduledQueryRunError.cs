// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using System.Text.Json.Serialization;

    public class ScheduledQueryRunError : StripeEntity<ScheduledQueryRunError>
    {
        /// <summary>
        /// Information about the run failure.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
