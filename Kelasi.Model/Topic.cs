using System.Collections.Generic;

namespace Kelasi.Model
{
    public class Topic 
    {
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual List<Category> Categories { get; set; }
    }
}
