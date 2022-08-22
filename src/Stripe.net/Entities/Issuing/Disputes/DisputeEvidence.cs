// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class DisputeEvidence : StripeEntity<DisputeEvidence>
    {
        [JsonPropertyName("canceled")]
        public DisputeEvidenceCanceled Canceled { get; set; }

        [JsonPropertyName("duplicate")]
        public DisputeEvidenceDuplicate Duplicate { get; set; }

        [JsonPropertyName("fraudulent")]
        public DisputeEvidenceFraudulent Fraudulent { get; set; }

        [JsonPropertyName("merchandise_not_as_described")]
        public DisputeEvidenceMerchandiseNotAsDescribed MerchandiseNotAsDescribed { get; set; }

        [JsonPropertyName("not_received")]
        public DisputeEvidenceNotReceived NotReceived { get; set; }

        [JsonPropertyName("other")]
        public DisputeEvidenceOther Other { get; set; }

        /// <summary>
        /// The reason for filing the dispute. Its value will match the field containing the
        /// evidence.
        /// One of: <c>canceled</c>, <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>merchandise_not_as_described</c>, <c>not_received</c>, <c>other</c>, or
        /// <c>service_not_as_described</c>.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("service_not_as_described")]
        public DisputeEvidenceServiceNotAsDescribed ServiceNotAsDescribed { get; set; }
    }
}
