using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Domain.Entities.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AmdarisInternship.Infrastructure.Configurations;

namespace AmdarisInternship.Infrastructure.Context
{
    public class AmdarisInternshipContext : IdentityDbContext<ApplicationUser, Role, long>  // DbContext
    {
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamGradeComponent> ExamGradeComponents { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleGrading> ModuleGradings { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionModule> PromotionModules { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAvatar> UserAvatars { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<UserPromotion> UserPromotions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserSkype> UserSkypes { get; set; }


        public AmdarisInternshipContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AttachmentConfig());
            modelBuilder.ApplyConfiguration(new ExamConfig());
            modelBuilder.ApplyConfiguration(new ExamGradeComponentConfig());
            modelBuilder.ApplyConfiguration(new GradeConfig());
            modelBuilder.ApplyConfiguration(new LessonConfig());
            modelBuilder.ApplyConfiguration(new ModuleConfig());
            modelBuilder.ApplyConfiguration(new PromotionConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new UserAvatarConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new UserEmailConfig());
            modelBuilder.ApplyConfiguration(new UserPromotionConfig());
            modelBuilder.ApplyConfiguration(new UserRoleConfig());
            modelBuilder.ApplyConfiguration(new UserSkypeConfig());
        }
    }
}
