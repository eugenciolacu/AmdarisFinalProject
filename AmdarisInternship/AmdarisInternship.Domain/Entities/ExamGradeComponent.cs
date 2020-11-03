using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class ExamGradeComponent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Weight { get; set; }

        public float Grade { get; set; }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }
    }
}
