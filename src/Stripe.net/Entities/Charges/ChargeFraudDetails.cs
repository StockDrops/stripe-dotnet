// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargeFraudDetails : StripeEntity<ChargeFraudDetails>
    {
        /// <summary>
        /// Assessments from Stripe. If set, the value is <c>fraudulent</c>.
        /// </summary>
        [JsonPropertyName("stripe_report")]
        public string StripeReport { get; set; }

        /// <summary>
        /// Assessments reported by you. If set, possible values of are <c>safe</c> and
        /// <c>fraudulent</c>.
        /// </summary>
        [JsonPropertyName("user_report")]
        public string UserReport { get; set; }
    }
}
