using BlazorApp1.Shared;
using Stripe.Checkout;

namespace BlazorApp1.Server.ServerServices
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}
