using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class Module
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public List<Exam> Exams { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}
