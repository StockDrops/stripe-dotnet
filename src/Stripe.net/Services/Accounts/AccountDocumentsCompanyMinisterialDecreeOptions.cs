// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class AccountDocumentsCompanyMinisterialDecreeOptions : INestedOptions
    {
        /// <summary>
        /// One or more document ids returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>account_requirement</c>.
        /// </summary>
        [JsonPropertyName("files")]
        public List<string> Files { get; set; }
    }
}
