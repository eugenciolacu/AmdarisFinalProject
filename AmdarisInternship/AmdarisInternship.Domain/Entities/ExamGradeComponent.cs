using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class ExamGradeComponent : BaseEntity
    {
        public int ModuleGradingId { get; set; }

        public float Grade { get; set; }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }

        public ModuleGrading ModuleGrading { get; set; }
    }
}
