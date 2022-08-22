// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class DisputeEvidenceDetails : StripeEntity<DisputeEvidenceDetails>
    {
        /// <summary>
        /// Date by which evidence must be submitted in order to successfully challenge dispute.
        /// Will be null if the customer's bank or credit card company doesn't allow a response for
        /// this particular dispute.
        /// </summary>
        [JsonPropertyName("due_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DueBy { get; set; }

        /// <summary>
        /// Whether evidence has been staged for this dispute.
        /// </summary>
        [JsonPropertyName("has_evidence")]
        public bool HasEvidence { get; set; }

        /// <summary>
        /// Whether the last evidence submission was submitted past the due date. Defaults to
        /// <c>false</c> if no evidence submissions have occurred. If <c>true</c>, then delivery of
        /// the latest evidence is <em>not</em> guaranteed.
        /// </summary>
        [JsonPropertyName("past_due")]
        public bool PastDue { get; set; }

        /// <summary>
        /// The number of times evidence has been submitted. Typically, you may only submit evidence
        /// once.
        /// </summary>
        [JsonPropertyName("submission_count")]
        public long SubmissionCount { get; set; }
    }
}
