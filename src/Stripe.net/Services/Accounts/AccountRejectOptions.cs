// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountRejectOptions : BaseOptions
    {
        /// <summary>
        /// The reason for rejecting the account. Can be <c>fraud</c>, <c>terms_of_service</c>, or
        /// <c>other</c>.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
