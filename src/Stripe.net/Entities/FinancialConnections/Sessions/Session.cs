// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Financial Connections Session is the secure way to programmatically launch the
    /// client-side Stripe.js modal that lets your users link their accounts.
    /// </summary>
    public class Session : StripeEntity<Session>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account holder for whom accounts are collected in this session.
        /// </summary>
        [JsonPropertyName("account_holder")]
        public SessionAccountHolder AccountHolder { get; set; }

        /// <summary>
        /// The accounts that were collected as part of this Session.
        /// </summary>
        [JsonPropertyName("accounts")]
        public StripeList<Account> Accounts { get; set; }

        /// <summary>
        /// A value that will be passed to the client to launch the authentication flow.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        [JsonPropertyName("filters")]
        public SessionFilters Filters { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Permissions requested for accounts collected during this session.
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// For webview integrations only. Upon completing OAuth login in the native browser, the
        /// user will be redirected to this URL to return to your app.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
