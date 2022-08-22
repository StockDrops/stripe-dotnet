// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountBusinessProfileOptions : INestedOptions
    {
        /// <summary>
        /// <a href="https://stripe.com/docs/connect/setting-mcc">The merchant category code for the
        /// account</a>. MCCs are used to classify businesses based on the goods or services they
        /// provide.
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// The customer-facing business name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Internal-only description of the product sold by, or service provided by, the business.
        /// Used by Stripe for risk and underwriting purposes.
        /// </summary>
        [JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// A publicly available mailing address for sending support issues to.
        /// </summary>
        [JsonPropertyName("support_address")]
        public AddressOptions SupportAddress { get; set; }

        /// <summary>
        /// A publicly available email address for sending support issues to.
        /// </summary>
        [JsonPropertyName("support_email")]
        public string SupportEmail { get; set; }

        /// <summary>
        /// A publicly available phone number to call with support issues.
        /// </summary>
        [JsonPropertyName("support_phone")]
        public string SupportPhone { get; set; }

        /// <summary>
        /// A publicly available website for handling support issues.
        /// </summary>
        [JsonPropertyName("support_url")]
        public string SupportUrl { get; set; }

        /// <summary>
        /// The business's publicly available website.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
