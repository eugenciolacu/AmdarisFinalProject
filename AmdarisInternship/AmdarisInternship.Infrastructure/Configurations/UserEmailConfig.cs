using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserEmailConfig : IEntityTypeConfiguration<UserEmail>
    {
        public void Configure(EntityTypeBuilder<UserEmail> builder)
        {
            
        }
    }
}
