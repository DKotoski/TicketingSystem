using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Core
{
    public class Project:BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Team> Teams { get; set; }
    }
}
