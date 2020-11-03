using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class UserLog
    {
        public int Id { get; set; }

        public Nullable<int> OldUserRoleId { get; set; }

        public int NewUserRoleId { get; set; }

        public DateTime UpdateTime { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
