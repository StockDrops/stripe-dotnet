// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionShippingAddressCollectionOptions : INestedOptions
    {
        /// <summary>
        /// An array of two-letter ISO country codes representing which countries Checkout should
        /// provide as options for shipping locations. Unsupported country codes: <c>AS, CX, CC, CU,
        /// HM, IR, KP, MH, FM, NF, MP, PW, SD, SY, UM, VI</c>.
        /// </summary>
        [JsonPropertyName("allowed_countries")]
        public List<string> AllowedCountries { get; set; }
    }
}
