namespace Stripe
{
    public interface IBaseStripeList
    {
        bool HasMore { get; set; }

        string Object { get; set; }

        string Url { get; set; }
    }
}