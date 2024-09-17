using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Private.Controllers
{
    [Authorize]
    [Route("~/private-api/[controller]/[action]")]
    [ApiController]
    public class PrivateController : ControllerBase
    {
        private readonly ILogger<PrivateController> _logger;

        public PrivateController(ILogger<PrivateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string First()
        {
            return "Private service - First";
        }

        [HttpGet]
        public string Second()
        {
            return "Private service - Second";
        }
    }
}
