using System.Collections.Generic;

namespace AmdarisInternship.Domain.Entities
{
    public class Role : BaseEntity
    {
        public Enums.Role Role_ { get; set; }


        public List<UserRole> UserRoles { get; set; }
    }
}
