namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class DiscountTest : BaseStripeTest
    {
        public DiscountTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.discount.json");
            var discount = JsonSerializer.Deserialize<Discount>(json);

            Assert.NotNull(discount);
            Assert.Equal("discount", discount.Object);
            Assert.NotNull(discount.Coupon);
            Assert.Equal("coupon", discount.Coupon.Object);
        }
    }
}
