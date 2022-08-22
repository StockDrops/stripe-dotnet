// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// Information for the account this token will represent.
        /// </summary>
        [JsonPropertyName("account")]
        public TokenAccountOptions Account { get; set; }

        [JsonPropertyName("bank_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, TokenBankAccountOptions> BankAccount { get; set; }

        [JsonPropertyName("card")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, TokenCardOptions> Card { get; set; }

        /// <summary>
        /// The customer (owned by the application's account) for which to create a token. This can
        /// be used only with an <a href="https://stripe.com/docs/connect/standard-accounts">OAuth
        /// access token</a> or <a
        /// href="https://stripe.com/docs/connect/authentication">Stripe-Account header</a>. For
        /// more details, see <a
        /// href="https://stripe.com/docs/connect/cloning-saved-payment-methods">Cloning Saved
        /// Payment Methods</a>.
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The updated CVC value this token will represent.
        /// </summary>
        [JsonPropertyName("cvc_update")]
        public TokenCvcUpdateOptions CvcUpdate { get; set; }

        /// <summary>
        /// Information for the person this token will represent.
        /// </summary>
        [JsonPropertyName("person")]
        public TokenPersonOptions Person { get; set; }

        /// <summary>
        /// The PII this token will represent.
        /// </summary>
        [JsonPropertyName("pii")]
        public TokenPiiOptions Pii { get; set; }
    }
}
