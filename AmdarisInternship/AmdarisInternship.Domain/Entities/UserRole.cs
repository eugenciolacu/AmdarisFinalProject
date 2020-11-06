using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class UserRole : BaseEntity
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }

        public Role Role { get; set; }

        public User User { get; set; }
    }
}
