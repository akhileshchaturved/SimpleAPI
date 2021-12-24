using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
 

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
           

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string []{"values1","values2"};
        }
      
        [HttpGet("{id}")]
        public  ActionResult<string> Get(int id)
        {
            return "anything else";
        }
 
    }
}
