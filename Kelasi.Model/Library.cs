using System.Collections.Generic;
namespace Kelasi.Model 
{
    public class Library 
    {
        public int LibraryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public virtual List<Topic> Topics { get; set; }
    }
}
