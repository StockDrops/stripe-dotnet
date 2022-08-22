namespace StripeTests.Radar
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe.Radar;
    using Xunit;

    public class ValueListTest : BaseStripeTest
    {
        public ValueListTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/radar/value_lists/rsl_123");
            var valueList = JsonSerializer.Deserialize<ValueList>(json);
            Assert.NotNull(valueList);
            Assert.IsType<ValueList>(valueList);
            Assert.NotNull(valueList.Id);
            Assert.Equal("radar.value_list", valueList.Object);
        }
    }
}
