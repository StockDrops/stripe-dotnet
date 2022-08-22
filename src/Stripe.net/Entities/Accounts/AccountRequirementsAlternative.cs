// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class AccountRequirementsAlternative : StripeEntity<AccountRequirementsAlternative>
    {
        /// <summary>
        /// Fields that can be provided to satisfy all fields in <c>original_fields_due</c>.
        /// </summary>
        [JsonPropertyName("alternative_fields_due")]
        public List<string> AlternativeFieldsDue { get; set; }

        /// <summary>
        /// Fields that are due and can be satisfied by providing all fields in
        /// <c>alternative_fields_due</c>.
        /// </summary>
        [JsonPropertyName("original_fields_due")]
        public List<string> OriginalFieldsDue { get; set; }
    }
}
