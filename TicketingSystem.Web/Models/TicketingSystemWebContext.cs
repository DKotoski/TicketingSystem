using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketingSystem.Web.Models
{
    public class TicketingSystemWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TicketingSystemWebContext() : base("name=TicketingSystemWebContext")
        {
        }

        public System.Data.Entity.DbSet<TicketingSystem.Core.Ticket> Tickets { get; set; }

        public System.Data.Entity.DbSet<TicketingSystem.Core.User> Users { get; set; }
    }
}
