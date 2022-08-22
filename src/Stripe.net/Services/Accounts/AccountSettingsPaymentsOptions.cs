// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountSettingsPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// The default text that appears on credit card statements when a charge is made. This
        /// field prefixes any dynamic <c>statement_descriptor</c> specified on the charge.
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The Kana variation of the default text that appears on credit card statements when a
        /// charge is made (Japan only).
        /// </summary>
        [JsonPropertyName("statement_descriptor_kana")]
        public string StatementDescriptorKana { get; set; }

        /// <summary>
        /// The Kanji variation of the default text that appears on credit card statements when a
        /// charge is made (Japan only).
        /// </summary>
        [JsonPropertyName("statement_descriptor_kanji")]
        public string StatementDescriptorKanji { get; set; }
    }
}
