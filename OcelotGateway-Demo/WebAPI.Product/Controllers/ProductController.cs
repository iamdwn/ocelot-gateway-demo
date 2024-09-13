using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Product.Controllers
{
    [Route("~/product-api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string First()
        {
            return "Product service - First";
        }

        [HttpGet]
        public string Second()
        {
            return "Product service - Second";
        }
    }
}
