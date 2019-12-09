using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AbilitySaleCloud.ApiGateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : ControllerBase
    {
        
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            return Ok("Hello!");
        }
    }
}