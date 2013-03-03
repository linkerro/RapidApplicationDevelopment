using RapidApplicationDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RapidApplicationDevelopment.Controllers
{
    public class FiltersController : ApiController
    {
        // GET api/filters
        public IEnumerable<FilterModel> Get()
        {
            using (Entities entities = new Entities("Entities"))
            {
                var userId = Guid.Parse("f8200f41-3c21-4da2-b646-bd1b875e381a");
                var filters = entities.Filters.Where(x => x.UserId == userId).Select(x => new FilterModel() { Id=x.Id,Name=x.Name,MailCount=x.Mails.Count }).ToList();
                return filters;
            }
        }

        // GET api/filters/5
        public IEnumerable<Mail> GetFilterMails(int id)
        {
            using (Entities entities = new Entities("Entities"))
            {
                return entities.Mails.Where(x => x.Filters.Where(f => f.Id == id).Count() > 0).ToList();
            }
        }
    }
}
