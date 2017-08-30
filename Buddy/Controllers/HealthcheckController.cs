using Microsoft.AspNetCore.Mvc;

namespace Buddy.WebApi.Controllers
{
    public class HealthcheckController : Controller
    {
        [HttpGet]
        [Route("ping")]
        public IActionResult Ping()
        {
            return Ok();
        }
    }
}