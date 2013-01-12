namespace Kelasi.Model
{
    public class Author : User
    {
        public int AuthorId { get; set; }
        public Rating Rating { get; set; }
        public string Bio { get; set; }
        public string Title { get; set; }
    }
}
