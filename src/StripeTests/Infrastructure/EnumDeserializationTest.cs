namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class EnumDeserializationTest : BaseStripeTest
    {
        [Fact]
        public void EnumDecodeValueWithEnumMember()
        {
            var json = "{\"enum\": \"test_one\"}";
            TestOptions obj = JsonSerializer.Deserialize<TestOptions>(json);

            Assert.NotNull(obj);
            Assert.Equal(TestOptions.TestEnum.TestOne, obj.Enum);
        }

        [Fact]
        public void EnumDecodeValueWithoutEnumMember()
        {
            var json = "{\"enum\": \"TestTwo\"}";
            TestOptions obj = JsonSerializer.Deserialize<TestOptions>(json);

            Assert.NotNull(obj);
            Assert.Equal(TestOptions.TestEnum.TestTwo, obj.Enum);
        }

        [Fact]
        public void DecodingShouldThrowIfValueNotDeclaredInEnum()
        {
            var json = "{\"enum\": \"unknown_value\"}";

            var exception = Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<TestOptions>(json));

            Assert.Contains("Error converting value \"unknown_value\"", exception.Message);
        }
    }
}
