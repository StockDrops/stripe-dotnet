namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SourceCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonPropertyName("alipay")]
        public string Alipay { get; set; }

        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonPropertyName("flow")]
        public string Flow { get; set; }

        [JsonPropertyName("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("original_source")]
        public string OriginalSource { get; set; }

        [JsonPropertyName("owner")]
        public SourceOwnerOptions Owner { get; set; }

        [JsonPropertyName("receiver")]
        public SourceReceiverOptions Receiver { get; set; }

        [JsonPropertyName("redirect")]
        public SourceRedirectOptions Redirect { get; set; }

        [JsonPropertyName("source_order")]
        public SourceSourceOrderOptions SourceOrder { get; set; }

        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("usage")]
        public string Usage { get; set; }

        /*
           Below we group all Source type specific paramters
        */

        [JsonPropertyName("acss_debit")]
        public SourceAcssDebitCreateOptions AcssDebit { get; set; }

        [JsonPropertyName("au_becs_debit")]
        public SourceAuBecsDebitCreateOptions AuBecsDebit { get; set; }

        [JsonPropertyName("bancontact")]
        public SourceBancontactCreateOptions Bancontact { get; set; }

        [JsonPropertyName("card")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<string, SourceCardOptions> Card { get; set; }

        [JsonPropertyName("ideal")]
        public SourceIdealCreateOptions Ideal { get; set; }

        [JsonPropertyName("klarna")]
        public SourceKlarnaCreateOptions Klarna { get; set; }

        [JsonPropertyName("sepa_debit")]
        public SourceSepaDebitCreateOptions SepaDebit { get; set; }

        [JsonPropertyName("sofort")]
        public SourceSofortCreateOptions Sofort { get; set; }

        [JsonPropertyName("three_d_secure")]
        public SourceThreeDSecureCreateOptions ThreeDSecure { get; set; }

        [JsonPropertyName("wechat")]
        public SourceWechatCreateOptions Wechat { get; set; }
    }
}
