namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class CapabilityTest : BaseStripeTest
    {
        public CapabilityTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/accounts/acct_123/capabilities/acap_123");
            var capability = JsonSerializer.Deserialize<Capability>(json);
            Assert.NotNull(capability);
            Assert.IsType<Capability>(capability);
            Assert.NotNull(capability.Id);
            Assert.Equal("capability", capability.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "account",
            };

            string json = this.GetFixture("/v1/accounts/acct_123/capabilities/acap_123", expansions);
            var capability = JsonSerializer.Deserialize<Capability>(json);
            Assert.NotNull(capability);
            Assert.IsType<Capability>(capability);
            Assert.NotNull(capability.Id);
            Assert.Equal("capability", capability.Object);

            Assert.NotNull(capability.Account);
            Assert.Equal("account", capability.Account.Object);
        }
    }
}
