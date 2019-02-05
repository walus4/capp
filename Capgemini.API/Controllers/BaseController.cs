using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}