// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SetupIntentNextActionRedirectToUrl : StripeEntity<SetupIntentNextActionRedirectToUrl>
    {
        /// <summary>
        /// If the customer does not exit their browser while authenticating, they will be
        /// redirected to this specified URL after completion.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL you must redirect your customer to in order to authenticate.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
