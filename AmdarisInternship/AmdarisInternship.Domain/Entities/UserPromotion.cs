﻿namespace AmdarisInternship.Domain.Entities
{
    public class UserPromotion : BaseEntity
    {
        public int UserId { get; set; }

        public int PromotionId { get; set; }

        public User User { get; set; }

        public Promotion Promotion { get; set; }
    }
}
