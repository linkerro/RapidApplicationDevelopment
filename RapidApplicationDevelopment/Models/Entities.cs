using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RapidApplicationDevelopment.Models
{
    public partial class Entities
    {
        public Entities(string connectionString)
            : base(connectionString)
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}