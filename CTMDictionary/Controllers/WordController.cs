using Microsoft.AspNetCore.Mvc;

namespace CTMDictionary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "hello world";
        }
    }
}
