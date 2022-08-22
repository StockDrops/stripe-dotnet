// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderProcessConfigOptions : INestedOptions
    {
        /// <summary>
        /// Override showing a tipping selection screen on this transaction.
        /// </summary>
        [JsonPropertyName("skip_tipping")]
        public bool? SkipTipping { get; set; }
    }
}
