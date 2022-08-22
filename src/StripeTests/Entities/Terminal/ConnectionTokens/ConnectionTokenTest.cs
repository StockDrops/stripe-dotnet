namespace StripeTests.Terminal
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe.Terminal;
    using Xunit;

    public class ConnectionTokenTest : BaseStripeTest
    {
        public ConnectionTokenTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.connection_token.json");
            var connectionToken = JsonSerializer.Deserialize<ConnectionToken>(json);
            Assert.NotNull(connectionToken);
            Assert.IsType<ConnectionToken>(connectionToken);
            Assert.NotNull(connectionToken.Secret);
            Assert.Equal("terminal.connection_token", connectionToken.Object);
        }
    }
}
