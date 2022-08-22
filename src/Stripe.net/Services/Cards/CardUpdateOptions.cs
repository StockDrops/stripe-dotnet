// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The bank account type. This can only be <c>checking</c> or <c>savings</c> in most
        /// countries. In Japan, this can only be <c>futsu</c> or <c>toza</c>.
        /// One of: <c>checking</c>, <c>futsu</c>, <c>savings</c>, or <c>toza</c>.
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [JsonPropertyName("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided when creating card.
        /// </summary>
        [JsonPropertyName("address_country")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [JsonPropertyName("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [JsonPropertyName("address_line2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [JsonPropertyName("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonPropertyName("address_zip")]
        public string AddressZip { get; set; }

        [JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("validate")]
        public bool? Validate { get; set; }
    }
}
