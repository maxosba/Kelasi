using System;


namespace Kelasi.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleasedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Duration { get; set; }
        public Rating Rating { get; set; }
        public Level Level { get; set; }
        public int NumberOfviewers { get; set; }
        public int NumberOfSubscribers { get; set; }
        public int Size { get; set; }
        public Status Status { get; set; }
        public string Url { get; set; }
        public string ImagePath { get; set; }
        public Featured Featured { get; set; }

        // Navigation properties
        public virtual Category Category { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual Author AuthorI { get; set; }
        public virtual Language Language { get; set; }
    }
}
