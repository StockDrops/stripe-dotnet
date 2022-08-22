namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;
    using Xunit;

    public class JsonUtilsTest : BaseStripeTest
    {
        [Fact]
        public void DeserializeObjectIgnoresDefaultSettings()
        {
            var origDefaultSettings = new JsonSerializerOptions();

            try
            {
                origDefaultSettings.DefaultIgnoreCondition = JsonIgnoreCondition.Never;

                var s = "{\"int\":234,\"string\":\"Hello!\",\"foo\":\"bar\"}";

                // Deserialization throws an exception because of the extra `foo` property that is
                // missing in the TestObject class.
                Assert.Throws<JsonException>(() =>
                    JsonSerializer.Deserialize<TestObject>(s, origDefaultSettings));

                // Deserialization succeeds because we're not using DefaultSettings, so
                // MissingMemberHandling is set to its default value Ignore instead of Error.
                var objStripe = JsonUtils.DeserializeObject<TestObject>(s);
                Assert.NotNull(objStripe);
                Assert.Equal(234, objStripe.Int);
                Assert.Equal("Hello!", objStripe.String);
            }
            finally
            {
            }
        }

        [Fact]
        public void SerializeObjectIgnoresDefaultSettings()
        {
            var origDefaultSettings = new JsonSerializerOptions();

            try
            {
                origDefaultSettings.ReferenceHandler = ReferenceHandler.Preserve;
                origDefaultSettings.WriteIndented = true;

                var o = new TestObject { Int = 234, String = "Hello!" };

                // Serialized string is formatted with newlines and indentation because of
                // Formatting.Indented, and includes `$id` keys because of
                // PreserveReferencesHandling.All.
                var jsonDefault = JsonSerializer.Serialize(o, origDefaultSettings);
                jsonDefault = jsonDefault.Replace("\r\n", "\n");
                Assert.Equal(
                    "{\n  \"$id\": \"1\",\n  \"int\": 234,\n  \"string\": \"Hello!\"\n}",
                    jsonDefault);

                // Serialized string is not formatted and doesn't include `$id` keys because
                // we're not using DefaultSettings.
                var jsonStripe = JsonUtils.SerializeObject(o);
                jsonStripe = jsonStripe.Replace("\r\n", "\n");
                Assert.Equal("{\"int\":234,\"string\":\"Hello!\"}", jsonStripe);
            }
            finally
            {
            }
        }

        private class TestObject
        {
            [JsonPropertyName("int")]
            public int Int { get; set; }

            [JsonPropertyName("string")]
            public string String { get; set; }
        }
    }
}
