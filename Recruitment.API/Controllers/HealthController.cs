using Microsoft.AspNetCore.Mvc;

namespace Recruitment.API.Controllers
{
    [Route("api/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet()]
        [HttpHead()]
        public string Get()
        {
            return "value";
        }
    }
}
