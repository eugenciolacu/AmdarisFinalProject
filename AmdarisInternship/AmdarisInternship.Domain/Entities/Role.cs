using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AmdarisInternship.Domain.Entities
{
    public class Role : IdentityRole<long>
    {
        public Enums.Role Role_ { get; set; }


        public List<UserRole> UserRoles { get; set; }
    }
}
