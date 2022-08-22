// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountController : StripeEntity<AccountController>
    {
        /// <summary>
        /// <c>true</c> if the Connect application retrieving the resource controls the account and
        /// can therefore exercise <a
        /// href="https://stripe.com/docs/connect/platform-controls-for-standard-accounts">platform
        /// controls</a>. Otherwise, this field is null.
        /// </summary>
        [JsonPropertyName("is_controller")]
        public bool IsController { get; set; }

        /// <summary>
        /// The controller type. Can be <c>application</c>, if a Connect application controls the
        /// account, or <c>account</c>, if the account controls itself.
        /// One of: <c>account</c>, or <c>application</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
