using System;
using System.Collections.Generic;

namespace placeMarket.api.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CompletionTime { get; set; }
        public string ComplexityLevel { get; set; }
        public string PhotoUrl { get; set; }
        public string VideoUrl { get; set; }
        public string AddressedTo { get; set; }
        public string Requirements { get; set; } // JSON
        public double Duration { get; set; }
        public string CourseAchievements { get; set; } // JSON
        public int Order { get; set; } // JSON
        public Boolean BestSeller { get; set; }
        public Boolean UnlimitedAccess { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsRoot { get; set; }
        public bool DefaultEnroll { get; set; }
        public int Version { get; set; }
        public string VersionName { get; set; }
        public string Status { get; set; }
        public string CommentStatus { get; set; }
        public int? WordPressId { get; set; }
        public int? AuthorId { get; set; }
        public string TeacherReference { get; set; }
        public virtual ICollection<CourseCategory> CourseCategories { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public int DeleteUserId { get; set; }

    }
}