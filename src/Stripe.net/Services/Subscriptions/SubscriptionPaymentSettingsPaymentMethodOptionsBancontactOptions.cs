// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsBancontactOptions : INestedOptions
    {
        /// <summary>
        /// Preferred language of the Bancontact authorization page that the customer is redirected
        /// to.
        /// One of: <c>de</c>, <c>en</c>, <c>fr</c>, or <c>nl</c>.
        /// </summary>
        [JsonPropertyName("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
