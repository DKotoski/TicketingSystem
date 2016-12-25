using System.Collections.Generic;

namespace TicketingSystem.Core
{
    public class Permission:BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Role> Roles { get; set; }
    }
}