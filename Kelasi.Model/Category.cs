using System.Collections.Generic;

namespace Kelasi.Model
{
    public class Category 
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Course> Videos { get; set; } 
    }
}
