using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebService.Controllers
{
    [Route("/")]
    public class HelloController : Controller
    {
        private const string MESSAGE_FORMAT = "Hello {0}!";
// comment
        [HttpGet]
        public JsonResult Get([FromQuery] string name = "World")
        {
            return Json(new Response(string.Format(MESSAGE_FORMAT, name)));
        }

        [HttpPost]
        public JsonResult Post([FromBody]string name = "World")
        {
            return Json(new Response(string.Format(MESSAGE_FORMAT, name)));
        }
    }
}
