namespace AmdarisInternship.Domain.Entities
{
    public class Attachment : BaseEntity
    {
        public byte[] Attachment_ { get; set; }

        public int LessonId { get; set; }
        

        public Lesson Lesson { get; set; }
    }
}
