// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceCardPresent : StripeEntity<SourceCardPresent>
    {
        [JsonPropertyName("application_cryptogram")]
        public string ApplicationCryptogram { get; set; }

        [JsonPropertyName("application_preferred_name")]
        public string ApplicationPreferredName { get; set; }

        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonPropertyName("authorization_response_code")]
        public string AuthorizationResponseCode { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("cvm_type")]
        public string CvmType { get; set; }

        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        [JsonPropertyName("dedicated_file_name")]
        public string DedicatedFileName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("emv_auth_data")]
        public string EmvAuthData { get; set; }

        [JsonPropertyName("evidence_customer_signature")]
        public string EvidenceCustomerSignature { get; set; }

        [JsonPropertyName("evidence_transaction_certificate")]
        public string EvidenceTransactionCertificate { get; set; }

        [JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("funding")]
        public string Funding { get; set; }

        [JsonPropertyName("iin")]
        public string Iin { get; set; }

        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("pos_device_id")]
        public string PosDeviceId { get; set; }

        [JsonPropertyName("pos_entry_mode")]
        public string PosEntryMode { get; set; }

        [JsonPropertyName("read_method")]
        public string ReadMethod { get; set; }

        [JsonPropertyName("reader")]
        public string Reader { get; set; }

        [JsonPropertyName("terminal_verification_results")]
        public string TerminalVerificationResults { get; set; }

        [JsonPropertyName("transaction_status_information")]
        public string TransactionStatusInformation { get; set; }
    }
}
