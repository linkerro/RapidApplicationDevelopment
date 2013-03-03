using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RapidApplicationDevelopment.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetFilters()
        {
            return new string[] { "value1", "value2" };
        }



    }
}