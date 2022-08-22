// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class DisputeEvidenceOptions : INestedOptions
    {
        /// <summary>
        /// Evidence provided when <c>reason</c> is 'canceled'.
        /// </summary>
        [JsonPropertyName("canceled")]
        public DisputeEvidenceCanceledOptions Canceled { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'duplicate'.
        /// </summary>
        [JsonPropertyName("duplicate")]
        public DisputeEvidenceDuplicateOptions Duplicate { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'fraudulent'.
        /// </summary>
        [JsonPropertyName("fraudulent")]
        public DisputeEvidenceFraudulentOptions Fraudulent { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'merchandise_not_as_described'.
        /// </summary>
        [JsonPropertyName("merchandise_not_as_described")]
        public DisputeEvidenceMerchandiseNotAsDescribedOptions MerchandiseNotAsDescribed { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'not_received'.
        /// </summary>
        [JsonPropertyName("not_received")]
        public DisputeEvidenceNotReceivedOptions NotReceived { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'other'.
        /// </summary>
        [JsonPropertyName("other")]
        public DisputeEvidenceOtherOptions Other { get; set; }

        /// <summary>
        /// The reason for filing the dispute. The evidence should be submitted in the field of the
        /// same name.
        /// One of: <c>canceled</c>, <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>merchandise_not_as_described</c>, <c>not_received</c>, <c>other</c>, or
        /// <c>service_not_as_described</c>.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'service_not_as_described'.
        /// </summary>
        [JsonPropertyName("service_not_as_described")]
        public DisputeEvidenceServiceNotAsDescribedOptions ServiceNotAsDescribed { get; set; }
    }
}
