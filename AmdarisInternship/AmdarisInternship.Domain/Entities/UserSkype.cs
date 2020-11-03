using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class UserSkype
    {
        public int Id { get; set; }

        public string Skype { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
