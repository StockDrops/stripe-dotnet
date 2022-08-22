namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json.Converters;
    using Stripe;
    using Stripe.Infrastructure;

    public class TestOptions : BaseOptions
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TestEnum
        {
            [EnumMember(Value = "test_one")]
            TestOne,

            // TestTwo purposefully doesn't define a serialization value
            TestTwo,
        }

        [JsonPropertyName("any_of")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, Dictionary<string, string>> AnyOf { get; set; }

        [JsonPropertyName("array")]
        public string[] Array { get; set; }

        [JsonPropertyName("bool")]
        public bool? Bool { get; set; }

        [JsonPropertyName("date_filter")]
        public DateRangeOptions DateRangeOptions { get; set; }

        [JsonPropertyName("datetime")]
        public DateTime? DateTime { get; set; }

        [JsonPropertyName("decimal")]
        public decimal? Decimal { get; set; }

        [JsonPropertyName("dictionary")]
        public Dictionary<string, object> Dictionary { get; set; }

        [JsonPropertyName("enum")]
        public TestEnum? Enum { get; set; }

        [JsonPropertyName("list")]
        public List<object> List { get; set; }

        [JsonPropertyName("long")]
        public long? Long { get; set; }

        [JsonPropertyName("stream")]
        public Stream Stream { get; set; }

        [JsonPropertyName("string")]
        public string String { get; set; }

        [JsonPropertyName("string_enum")]
        public TestStringEnum StringEnum { get; set; }

        public class TestStringEnum : StringEnum
        {
            public static readonly TestStringEnum Foo = new TestStringEnum("foo");

            private TestStringEnum(string value)
                : base(value)
            {
            }
        }
    }
}
