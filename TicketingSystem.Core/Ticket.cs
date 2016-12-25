using System;
using System.Collections.Generic;

namespace TicketingSystem.Core
{
    public class Ticket:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Project Project { get; set; }
        public TicketType Type { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public int Estimation{ get; set; }
        public int CurrentWorkTime{ get; set; }
        public string Code { get; set; }
        public virtual User Assignee { get; set; }
        public virtual User Assigner { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}