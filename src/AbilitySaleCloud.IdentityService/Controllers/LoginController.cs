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
        
<<<<<<< HEAD:src/AbilitySaleCloud.Identity/Controllers/LoginController.cs
        [HttpGet("get")]
=======
        [HttpGet("Get")]
>>>>>>> ce0908b5dfb2bb25fec74536fb761554fa33b995:src/AbilitySaleCloud.IdentityService/Controllers/LoginController.cs
        public async Task<IActionResult> GetLoggedUsers()
        {
            return Ok("10 users are logged in");
        }
            
    }
}