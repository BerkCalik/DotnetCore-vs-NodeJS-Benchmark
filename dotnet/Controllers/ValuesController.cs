using Microsoft.AspNetCore.Mvc;

namespace DotnetRider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var x = new
            {
                name = "Berk Çalık",
                age = 22
            };
            return new JsonResult(x);
        }
    }
}