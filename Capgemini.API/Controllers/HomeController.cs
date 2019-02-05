using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.API.Controllers
{
    [Route("")]
    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult Get()
            => Content("Capgemini.API");
    }
}