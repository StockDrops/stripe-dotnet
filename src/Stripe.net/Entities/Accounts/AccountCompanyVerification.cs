// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        [JsonPropertyName("document")]
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
