namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe;

    public class TestNestedOptions : INestedOptions
    {
        [JsonPropertyName("a_long")]
        public long? ALong { get; set; }

        [JsonPropertyName("a_string")]
        public string AString { get; set; }
    }
}
