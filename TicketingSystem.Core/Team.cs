using System.Collections.Generic;

namespace TicketingSystem.Core
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<Project> Projects { get; set; }
    }
}