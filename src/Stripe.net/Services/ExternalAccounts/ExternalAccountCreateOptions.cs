// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class ExternalAccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// When set to true, or if this is the first external account added in this currency, this
        /// account becomes the default external account for its currency.
        /// </summary>
        [JsonPropertyName("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonPropertyName("external_account")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<string, AccountBankAccountOptions> ExternalAccount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
