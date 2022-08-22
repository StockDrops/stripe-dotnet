// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardholderIndividualDobOptions : INestedOptions
    {
        /// <summary>
        /// The day of birth, between 1 and 31.
        /// </summary>
        [JsonPropertyName("day")]
        public long? Day { get; set; }

        /// <summary>
        /// The month of birth, between 1 and 12.
        /// </summary>
        [JsonPropertyName("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The four-digit year of birth.
        /// </summary>
        [JsonPropertyName("year")]
        public long? Year { get; set; }
    }
}
