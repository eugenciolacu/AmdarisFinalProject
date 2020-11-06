using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class UserEmail : BaseEntity
    {
        public string Email { get; set; }

        public int UserId { get; set; }

        
        public User User { get; set; }
    }
}
