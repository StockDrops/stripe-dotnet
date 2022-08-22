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
            Assert.NotNull(obj.RawJObject);
            Assert.Equal(2, obj.RawJObject.RootElement.GetProperty("unsupported_field").GetInt32());
            Assert.Equal(obj.RawJObject.ToString(), JsonDocument.Parse(json).ToString());
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
            Assert.NotNull(obj.RawJObject);
            Assert.Equal(obj.RawJObject.ToString(), JsonDocument.Parse(json).ToString());

            Assert.NotNull(obj.Child);
            Assert.Equal(1, obj.Child.ChildSupportedField);
            Assert.NotNull(obj.Child.RawJObject);
            Assert.Equal(2, obj.Child.RawJObject.RootElement.GetProperty("child_unsupported_field").GetInt32());
            Assert.Equal(obj.Child.RawJObject.ToString(), JsonDocument.Parse(childJson).ToString());
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
