using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserPromotionConfig : IEntityTypeConfiguration<UserPromotion>
    {
        public void Configure(EntityTypeBuilder<UserPromotion> builder)
        {
            
        }
    }
}
