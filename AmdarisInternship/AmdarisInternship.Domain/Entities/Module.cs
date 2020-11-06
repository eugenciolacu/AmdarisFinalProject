using System.Collections.Generic;

namespace AmdarisInternship.Domain.Entities
{
    public class Module : BaseEntity
    {
        public string Name { get; set; }


        public List<Exam> Exams { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}
