using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserAvatarConfig : IEntityTypeConfiguration<UserAvatar>
    {
        public void Configure(EntityTypeBuilder<UserAvatar> builder)
        {
            
        }
    }
}
