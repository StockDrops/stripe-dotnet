// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ReviewSession : StripeEntity<ReviewSession>
    {
        /// <summary>
        /// The browser used in this browser session (e.g., <c>Chrome</c>).
        /// </summary>
        [JsonPropertyName("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// Information about the device used for the browser session (e.g., <c>Samsung
        /// SM-G930T</c>).
        /// </summary>
        [JsonPropertyName("device")]
        public string Device { get; set; }

        /// <summary>
        /// The platform for the browser session (e.g., <c>Macintosh</c>).
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// The version for the browser session (e.g., <c>61.0.3163.100</c>).
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
