using System.Collections;

namespace Kelasi.Model
{
    public class Language 
    {
        public int LanguageId { get; set; }
        public string Title { get; set;}
        public string Description { get; set; }

        public virtual ICollection Videos { get; set; }
    }
}
