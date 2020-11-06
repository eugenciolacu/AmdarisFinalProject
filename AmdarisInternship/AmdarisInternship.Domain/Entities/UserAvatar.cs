using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class UserAvatar : BaseEntity
    {
        public string AvatarExtension { get; set; }

        public string AvatarName { get; set; }

        public byte[] Avatar { get; set; }

        public int UserId { get; set; }


        public User User { get; set; }
    }
}
