// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class AccountCompanyOwnershipDeclaration : StripeEntity<AccountCompanyOwnershipDeclaration>
    {
        /// <summary>
        /// The Unix timestamp marking when the beneficial owner attestation was made.
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the beneficial owner attestation was made.
        /// </summary>
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user-agent string from the browser where the beneficial owner attestation was made.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
