
using System.Collections.Generic;

namespace Kelasi.Model
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public List<Video> Videos { get; set; }
    }
}
