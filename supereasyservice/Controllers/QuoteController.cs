using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace supereasyservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        String[] quotes = new String[] { "Always Be Kind", "Do the right thing", "Do what works", "Changing how the world builds software" };
        Random random = new Random();
        // GET api/quote
        [HttpGet]
        public ActionResult<string> Get()
        {
            return quotes[random.Next(4)];
        }

        // GET api/quote/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return quotes[id];
        }
    }
}
