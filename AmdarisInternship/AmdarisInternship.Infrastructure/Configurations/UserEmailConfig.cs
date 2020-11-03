using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserEmailConfig : IEntityTypeConfiguration<UserEmail>
    {
        public void Configure(EntityTypeBuilder<UserEmail> builder)
        {
            builder.Property(ue => ue.Email)
                .IsRequired()
                .HasMaxLength(320);

            builder
                .HasIndex(ue => ue.Email)
                .IsUnique();

            builder
                .HasCheckConstraint("CK_UserEmail_Email", "Email != '' and Email LIKE '%_@_%._%'");

            builder
                .HasOne(ue => ue.User)
                .WithOne(u => u.UserEmail)
                .HasForeignKey<UserEmail>(ue => ue.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
