// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ApplePayDomainCreateOptions : BaseOptions
    {
        [JsonPropertyName("domain_name")]
        public string DomainName { get; set; }
    }
}
