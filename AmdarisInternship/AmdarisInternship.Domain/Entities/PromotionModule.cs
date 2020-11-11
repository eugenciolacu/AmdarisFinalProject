namespace AmdarisInternship.Domain.Entities
{
    public class PromotionModule : BaseEntity
    {
        public int ModuleId { get; set; }

        public int PromotionId { get; set; }

        public Module Module { get; set; }

        public Promotion Promotion { get; set; }
    }
}
