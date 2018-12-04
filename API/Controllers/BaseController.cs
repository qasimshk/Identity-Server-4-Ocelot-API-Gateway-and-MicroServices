using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Index()
        {
            return new
            {
                PingDate = DateTime.Now.ToShortDateString(),
                PingTime = DateTime.Now.ToShortTimeString(),
                PingStatus = "Active"
            };
        }
    }
}