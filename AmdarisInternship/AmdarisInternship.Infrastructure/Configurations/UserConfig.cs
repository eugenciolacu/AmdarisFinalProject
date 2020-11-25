using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasCheckConstraint("CK_User_FirstName", "FirstName != ''")
                .HasCheckConstraint("CK_User_LastName", "LastName != ''");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(320);

            builder
                .HasIndex(u => u.Email)
                .IsUnique();

            builder
                .HasCheckConstraint("CK_User_UserEmail", "Email != '' and Email LIKE '%_@_%._%'");

            //builder.Property(u => u.Skype)
            //    .IsRequired()
            //    .HasMaxLength(32);

            builder
                .HasIndex(us => us.Skype)
                .IsUnique();

            builder.HasCheckConstraint("CK_User_Skype", "DATALENGTH(Skype) >= 6 and Skype != ''");

            //builder.Property(ua => ua.AvatarExtension)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //builder.Property(ua => ua.AvatarName)
            //    .IsRequired()
            //    .HasMaxLength(256);

            //builder.Property(ua => ua.Avatar)
            //    .IsRequired();
        }
    }
}
