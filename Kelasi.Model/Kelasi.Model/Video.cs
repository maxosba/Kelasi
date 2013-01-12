using System;

namespace Kelasi.Model
{
    public class Video
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Released { get; set; }
        public DateTime Updated { get; set; }
        public string Duration { get; set; }
        public Rating Rating { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public int NumViewers { get; set; }
        public int NumSubscribers { get; set; }
        public int Size { get; set; }
        public Status Status { get; set; }
    }
}
