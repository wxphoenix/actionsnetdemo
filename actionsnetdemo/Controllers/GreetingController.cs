using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace actionsnetdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }
    }
}
