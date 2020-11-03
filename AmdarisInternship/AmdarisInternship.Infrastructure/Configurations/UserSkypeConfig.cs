using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserSkypeConfig : IEntityTypeConfiguration<UserSkype>
    {
        public void Configure(EntityTypeBuilder<UserSkype> builder)
        {
            builder.Property(us => us.Skype)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .HasIndex(us => us.Skype)
                .IsUnique();

            builder.HasCheckConstraint("CK_UserSkype_Skype", "DATALENGTH(Skype) >= 6 and Skype != ''");

            builder
                .HasOne(us => us.User)
                .WithOne(u => u.UserSkype)
                .HasForeignKey<UserSkype>(us => us.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
