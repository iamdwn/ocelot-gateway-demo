using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Cart.Controllers
{
    [Route("~/cart-api/[controller]/[action]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string First()
        {
            return "Cart service - First";
        }

        [HttpGet]
        public string Second()
        {
            return "Cart service - Second";
        }
    }
}
