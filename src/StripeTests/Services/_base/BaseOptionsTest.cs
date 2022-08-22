namespace StripeTests
{
    using System.Linq;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class BaseOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeAndDeserializeExpandAndExtraParams()
        {
            var options = new BaseOptions();
            options.AddExpand("expand_me");
            options.AddExtraParam("foo", "String!");
            options.AddExtraParam("bar", 234L);

            var json = JsonSerializer.Serialize(options);
            var deserialized = JsonSerializer.Deserialize<BaseOptions>(json, StripeConfiguration.SerializerSettings);

            Assert.Equal(options.Expand, deserialized.Expand);
            Assert.True(options.ExtraParams.Count == deserialized.ExtraParams.Count);
            Assert.All(
                deserialized.ExtraParams,
                kvp => Assert.Equal(options.ExtraParams[kvp.Key].ToString(), ((JsonElement)deserialized.ExtraParams[kvp.Key]).ToString()));

            Assert.True(((JsonElement)deserialized.ExtraParams["foo"]).ValueKind == JsonValueKind.String);
            Assert.True(((JsonElement)deserialized.ExtraParams["bar"]).ValueKind == JsonValueKind.Number);
        }
    }
}
