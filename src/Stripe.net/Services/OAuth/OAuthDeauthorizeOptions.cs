namespace Stripe
{
    using System.Text.Json.Serialization;

    public class OAuthDeauthorizeOptions : BaseOptions
    {
        /// <summary>
        /// The <c>client_id</c> of the application that you'd like to disconnect the account from.
        /// The account must be connected to this application.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>The account you'd like to disconnect from.</summary>
        [JsonPropertyName("stripe_user_id")]
        public string StripeUserId { get; set; }
    }
}
