namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe;

    public class TestOptionsWithList : BaseOptions
    {
        public TestOptionsWithList()
        {
            this.SomeList = new List<TestNestedOptions>
            {
                new TestNestedOptions
                {
                    ALong = 1,
                    AString = "foo",
                },
                new TestNestedOptions
                {
                    ALong = 2,
                    AString = "bar",
                },
            };
        }

        [JsonPropertyName("some_list")]
        public List<TestNestedOptions> SomeList { get; set; }
    }
}
