using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AbilitySaleCloud.Identity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet("get")]
        public async Task<IActionResult> GetLoggedUsers()
        {
            return Ok("10 users are logged in");
        }
            
    }
}