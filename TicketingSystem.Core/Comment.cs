using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Core
{
    public class Comment:BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public virtual User User { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
