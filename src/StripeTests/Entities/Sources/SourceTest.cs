namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class SourceTest : BaseStripeTest
    {
        public SourceTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/sources/src_123");
            var source = JsonSerializer.Deserialize<Source>(json);
            Assert.NotNull(source);
            Assert.IsType<Source>(source);
            Assert.NotNull(source.Id);
            Assert.Equal("source", source.Object);
        }
    }
}
