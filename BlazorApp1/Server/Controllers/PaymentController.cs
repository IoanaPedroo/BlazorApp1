using BlazorApp1.Server.ServerServices;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout")]
        public ActionResult CreateCheckoutSession(List<CartItem> cartItems)
        {
            var session = _paymentService.CreateCheckoutSession(cartItems);
            return Ok(session.Url);
        }
    }
}
