using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }

        public Nullable<float> Grade { get; set; }

        public int UserId { get; set; }

        public int ModuleId { get; set; }


        public User User { get; set; }

        public Module Module { get; set; }

        public List<ExamGradeComponent> ExamGradeComponents { get; set; }
    }
}
