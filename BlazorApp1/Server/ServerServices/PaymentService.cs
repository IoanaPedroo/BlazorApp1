using BlazorApp1.Shared;
using Stripe;
using Stripe.Checkout;

namespace BlazorApp1.Server.ServerServices
{
    public class PaymentService : IPaymentService
    {
        private readonly IConfiguration _configuration;
        public PaymentService(IConfiguration configuration)
        {
            _configuration = configuration;
            StripeConfiguration.ApiKey = _configuration.GetConnectionString("SecretStripeKey");

        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItmes = new  List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItmes.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = ci.ProductTitle,
                        Images = new List<string> { ci.Image }
                    }
                },
                Quantity = ci.Quantity,
            }));
            var options = new SessionCreateOptions
            {
                LineItems = lineItmes,
                Mode = "payment",
                SuccessUrl = "http://localhost:7272/order-success",
                CancelUrl = "http://localhost:7272/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return session;
        }
    }
}
