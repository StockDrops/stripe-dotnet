// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupAttemptPaymentMethodDetailsCard : StripeEntity<SetupAttemptPaymentMethodDetailsCard>
    {
        /// <summary>
        /// Populated if this authorization used 3D Secure authentication.
        /// </summary>
        [JsonPropertyName("three_d_secure")]
        public SetupAttemptPaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }
    }
}
