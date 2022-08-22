// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsInteracPresentReceipt : StripeEntity<ChargePaymentMethodDetailsInteracPresentReceipt>
    {
        /// <summary>
        /// The type of account being debited or credited.
        /// One of: <c>checking</c>, <c>savings</c>, or <c>unknown</c>.
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// EMV tag 9F26, cryptogram generated by the integrated circuit chip.
        /// </summary>
        [JsonPropertyName("application_cryptogram")]
        public string ApplicationCryptogram { get; set; }

        /// <summary>
        /// Mnenomic of the Application Identifier.
        /// </summary>
        [JsonPropertyName("application_preferred_name")]
        public string ApplicationPreferredName { get; set; }

        /// <summary>
        /// Identifier for this transaction.
        /// </summary>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// EMV tag 8A. A code returned by the card issuer.
        /// </summary>
        [JsonPropertyName("authorization_response_code")]
        public string AuthorizationResponseCode { get; set; }

        /// <summary>
        /// How the cardholder verified ownership of the card.
        /// </summary>
        [JsonPropertyName("cardholder_verification_method")]
        public string CardholderVerificationMethod { get; set; }

        /// <summary>
        /// EMV tag 84. Similar to the application identifier stored on the integrated circuit chip.
        /// </summary>
        [JsonPropertyName("dedicated_file_name")]
        public string DedicatedFileName { get; set; }

        /// <summary>
        /// The outcome of a series of EMV functions performed by the card reader.
        /// </summary>
        [JsonPropertyName("terminal_verification_results")]
        public string TerminalVerificationResults { get; set; }

        /// <summary>
        /// An indication of various EMV functions performed during the transaction.
        /// </summary>
        [JsonPropertyName("transaction_status_information")]
        public string TransactionStatusInformation { get; set; }
    }
}
