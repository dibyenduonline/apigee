using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi001
{
    [Route("api/[controller]/[action]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string MyRequets()
        {
            return " Processing at Server";
        }


        [HttpPost]
        public string MyRequets1()
        {
            return " Processing at Server as post";
        }


        [HttpPost]
        public string MyRequets2([FromBody]APIRequest input)
        {
            return " Processing at Server as post with method as "  + input.method1;
        }



    }
}