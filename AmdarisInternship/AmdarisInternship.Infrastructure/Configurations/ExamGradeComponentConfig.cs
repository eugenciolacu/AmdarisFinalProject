using AmdarisInternship.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmdarisInternship.Infrastructure.Configurations
{
    public class ExamGradeComponentConfig : IEntityTypeConfiguration<ExamGradeComponent>
    {
        public void Configure(EntityTypeBuilder<ExamGradeComponent> builder)
        {
            
        }
    }
}
