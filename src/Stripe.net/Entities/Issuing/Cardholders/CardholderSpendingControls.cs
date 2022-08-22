// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CardholderSpendingControls : StripeEntity<CardholderSpendingControls>
    {
        /// <summary>
        /// Array of strings containing <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-merchant_data-category">categories</a>
        /// of authorizations to allow. All other categories will be blocked. Cannot be set with
        /// <c>blocked_categories</c>.
        /// </summary>
        [JsonPropertyName("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        /// <summary>
        /// Array of strings containing <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-merchant_data-category">categories</a>
        /// of authorizations to decline. All other categories will be allowed. Cannot be set with
        /// <c>allowed_categories</c>.
        /// </summary>
        [JsonPropertyName("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        /// <summary>
        /// Limit spending with amount-based rules that apply across this cardholder's cards.
        /// </summary>
        [JsonPropertyName("spending_limits")]
        public List<CardholderSpendingControlsSpendingLimit> SpendingLimits { get; set; }

        /// <summary>
        /// Currency of the amounts within <c>spending_limits</c>.
        /// </summary>
        [JsonPropertyName("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
