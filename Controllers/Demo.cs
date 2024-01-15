using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Demo : ControllerBase
    {
        [HttpGet]
        public string SayHelloAPI()
        {
            return "Hello To API";
        }
    }
}
