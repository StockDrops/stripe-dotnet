namespace StripeTests.Issuing
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe.Issuing;
    using Xunit;

    public class AuthorizationTest : BaseStripeTest
    {
        public AuthorizationTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/issuing/authorizations/iauth_123");
            var authorization = JsonSerializer.Deserialize<Authorization>(json);
            Assert.NotNull(authorization);
            Assert.IsType<Authorization>(authorization);
            Assert.NotNull(authorization.Id);
            Assert.Equal("issuing.authorization", authorization.Object);

            Assert.NotNull(authorization.Card);
            Assert.Equal("issuing.card", authorization.Card.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "cardholder",
            };

            string json = this.GetFixture("/v1/issuing/authorizations/iauth_123", expansions);
            var authorization = JsonSerializer.Deserialize<Authorization>(json);
            Assert.NotNull(authorization);
            Assert.IsType<Authorization>(authorization);
            Assert.NotNull(authorization.Id);
            Assert.Equal("issuing.authorization", authorization.Object);

            Assert.NotNull(authorization.Cardholder);
            Assert.Equal("issuing.cardholder", authorization.Cardholder.Object);
        }
    }
}
