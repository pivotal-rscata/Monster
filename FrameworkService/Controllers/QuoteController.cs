using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FrameworkService.Controllers
{
    public class QuoteController : ApiController
    {
        String[] quotes = new String[] { "Always Be Kind", "Do the right thing", "Do what works", "Changing how the world builds software" };
        Random random = new Random();

        // GET api/quote
        public string Get()
        {
            return  quotes[random.Next(4)];
        }

        // GET api/quote/5
        public string Get(int id)
        {
            return quotes[id];
        }
    }
}
