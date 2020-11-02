using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserSkypeConfig : IEntityTypeConfiguration<UserSkype>
    {
        public void Configure(EntityTypeBuilder<UserSkype> builder)
        {
            
        }
    }
}
