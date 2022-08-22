// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PlanTransformUsageOptions : INestedOptions
    {
        /// <summary>
        /// Divide usage by this number.
        /// </summary>
        [JsonPropertyName("divide_by")]
        public long? DivideBy { get; set; }

        /// <summary>
        /// After division, either round the result <c>up</c> or <c>down</c>.
        /// One of: <c>down</c>, or <c>up</c>.
        /// </summary>
        [JsonPropertyName("round")]
        public string Round { get; set; }
    }
}
