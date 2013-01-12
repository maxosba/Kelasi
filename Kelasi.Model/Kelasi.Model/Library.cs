
using System.Collections.Generic;

namespace Kelasi.Model
{
    public class Library
    {
        public int LibraryId { get; set; }
        public int NumOfVideos { get; set;  }
        public List<Category> Categories { get; set; }
    }
}
