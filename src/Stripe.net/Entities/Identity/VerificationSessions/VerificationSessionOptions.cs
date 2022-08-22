// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Text.Json.Serialization;

    public class VerificationSessionOptions : StripeEntity<VerificationSessionOptions>
    {
        [JsonPropertyName("document")]
        public VerificationSessionOptionsDocument Document { get; set; }

        [JsonPropertyName("id_number")]
        public VerificationSessionOptionsIdNumber IdNumber { get; set; }
    }
}
