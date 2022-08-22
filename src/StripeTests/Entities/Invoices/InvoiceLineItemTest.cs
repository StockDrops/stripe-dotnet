namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class InvoiceLineItemTest : BaseStripeTest
    {
        public InvoiceLineItemTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/invoices/in_123/lines");
            var lineItems = JsonSerializer.Deserialize<StripeList<InvoiceLineItem>>(json);
            Assert.NotNull(lineItems);

            InvoiceLineItem lineItem = lineItems.Data[0];
            Assert.NotNull(lineItem);
            Assert.IsType<InvoiceLineItem>(lineItem);
            Assert.NotNull(lineItem.Id);
            Assert.Equal("line_item", lineItem.Object);
        }
    }
}
