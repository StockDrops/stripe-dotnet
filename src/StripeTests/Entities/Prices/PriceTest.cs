namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class PriceTest : BaseStripeTest
    {
        public PriceTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/prices/price_123");
            var price = JsonSerializer.Deserialize<Price>(json);
            Assert.NotNull(price);
            Assert.IsType<Price>(price);
            Assert.NotNull(price.Id);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "product",
            };

            string json = this.GetFixture("/v1/prices/price_123", expansions);
            var price = JsonSerializer.Deserialize<Price>(json);
            Assert.NotNull(price);
            Assert.IsType<Price>(price);
            Assert.NotNull(price.Id);
            Assert.Equal("price", price.Object);

            Assert.NotNull(price.Product);
            Assert.Equal("product", price.Product.Object);
        }
    }
}
