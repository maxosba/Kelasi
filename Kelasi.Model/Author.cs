using System.Collections.Generic;

namespace Kelasi.Model
{
    public class Author 
    {
        public int AuthorId { get; set; }
        public Rating Rating { get; set; }
        public string Bio { get; set; }
        public string Title { get; set; }
        public Featured Featured { get; set; }
        public Status Status { get; set; }

        // Navigation properties
        public User User { get; set; }
        public virtual ICollection<Course> Videos { get; set; }
        public virtual ICollection<Course> Topics { get; set; }
    }
}
