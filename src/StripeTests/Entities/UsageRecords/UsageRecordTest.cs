namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class UsageRecordTest : BaseStripeTest
    {
        public UsageRecordTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.usage_record.json");
            var usageRecord = JsonSerializer.Deserialize<UsageRecord>(json);

            Assert.NotNull(usageRecord);
            Assert.NotNull(usageRecord.Id);
            Assert.Equal("usage_record", usageRecord.Object);
        }
    }
}
