using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class UserPromotion
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PromotionId { get; set; }

        public User User { get; set; }

        public Promotion Promotion { get; set; }
    }
}
