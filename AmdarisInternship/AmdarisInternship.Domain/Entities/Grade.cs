using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class Grade
    {
        public int Id { get; set; }

        public float Grade_ { get; set; }

        public int UserId { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        public User User { get; set; }
    }
}
