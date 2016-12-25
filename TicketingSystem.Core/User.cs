using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Core
{
    public class User:BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual List<Team> Teams { get; set; }
        public virtual List<Role> Roles { get; set; }
        public virtual List<Ticket> WorksOn { get; set; }
        public virtual List<Ticket> Approves { get; set; }
    }
}
