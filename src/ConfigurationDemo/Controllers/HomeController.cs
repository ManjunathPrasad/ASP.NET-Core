using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationDemo.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly MySettings _settings;

        public HomeController(IOptions<MySettings> options, IConfiguration configuration)
        {
            _settings = options.Value;
        }

        [HttpGet("get-settings")]
        public IActionResult Index()
        {
            return Ok(new { Settings1 = _settings.Settings1, Settings2 = _settings.Settings2 });
        }
    }
}
