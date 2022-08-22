namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class StripeEntityConverterTest : BaseStripeTest
    {
        [Fact]
        public void DeserializeNull()
        {
            var json = "null";
            var obj = JsonSerializer.Deserialize<TestObject>(json);
            Assert.Null(obj);
        }

        [Fact]
        public void DeserializeRoot()
        {
            var json = @"{ 
                            ""supported_field"": 1, 
                            ""unsupported_field"": 2
                         }";
            var obj = JsonSerializer.Deserialize<TestObject>(json);
            Assert.Equal(1, obj.SupportedField);
        }

        [Fact]
        public void DeserializeChild()
        {
            var childJson = @"{
                                ""child_supported_field"": 1,
                                ""child_unsupported_field"": 2,
                              }";
            var json = $@"{{ ""child"": {childJson} }}";
            var obj = JsonSerializer.Deserialize<TestObject>(json);

            Assert.NotNull(obj);
            Assert.Null(obj.SupportedField);

            Assert.NotNull(obj.Child);
            Assert.Equal(1, obj.Child.ChildSupportedField);
        }

        private class TestObject : StripeEntity<TestObject>
        {
            [JsonPropertyName("supported_field")]
            public long? SupportedField { get; set; }

            [JsonPropertyName("child")]
            public TestChildObject Child { get; set; }
        }

        private class TestChildObject : StripeEntity<TestObject>
        {
            [JsonPropertyName("child_supported_field")]
            public long ChildSupportedField { get; set; }
        }
    }
}
