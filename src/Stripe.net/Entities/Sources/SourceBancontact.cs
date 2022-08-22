// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceBancontact : StripeEntity<SourceBancontact>
    {
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonPropertyName("bic")]
        public string Bic { get; set; }

        [JsonPropertyName("iban_last4")]
        public string IbanLast4 { get; set; }

        [JsonPropertyName("preferred_language")]
        public string PreferredLanguage { get; set; }

        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
