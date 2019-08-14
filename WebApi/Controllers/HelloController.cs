using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("hi/{name}")]
        public string GetHi(string name)
        {
            return "hi " + name;
        }
        [HttpGet("{welcome}")]
        public string Hi(string welcome)
        {
            if(welcome == "hi")
            {
                return "Hello";
            }
            else
            {
                return "I don't know who you are";
            }
        }
    }
}