using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserAvatarConfig : IEntityTypeConfiguration<UserAvatar>
    {
        public void Configure(EntityTypeBuilder<UserAvatar> builder)
        {
            builder.Property(ua => ua.AvatarExtension)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(ua => ua.AvatarName)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(ua => ua.Avatar)
                .IsRequired();

            builder
                .HasOne(ua => ua.User)
                .WithOne(u => u.UserAvatar)
                .HasForeignKey<UserAvatar>(ua => ua.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
