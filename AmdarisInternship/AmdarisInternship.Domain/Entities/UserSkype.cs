using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class UserSkype : BaseEntity
    {
        public string Skype { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
