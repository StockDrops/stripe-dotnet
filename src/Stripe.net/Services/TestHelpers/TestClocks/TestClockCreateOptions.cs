// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TestClockCreateOptions : BaseOptions
    {
        /// <summary>
        /// The initial frozen time for this test clock.
        /// </summary>
        [JsonPropertyName("frozen_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FrozenTime { get; set; }

        /// <summary>
        /// The name for this test clock.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
