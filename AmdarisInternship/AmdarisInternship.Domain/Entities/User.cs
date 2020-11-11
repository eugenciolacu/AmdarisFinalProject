using System;
using System.Collections.Generic;
using System.Text;

namespace AmdarisInternship.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Nullable<int> MentroId { get; set; }

        public Nullable<int> UserEmailId { get; set; }

        public Nullable<int> UserSkypeId { get; set; }

        public Nullable<int> UserAvatarId { get; set; }


        public UserEmail UserEmail { get; set; }

        public UserSkype UserSkype { get; set; }

        public UserAvatar UserAvatar { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public List<Exam> Exams { get; set; }

        public List<Grade> Grades { get; set; }

        public List<UserPromotion> UserPromotions { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}
