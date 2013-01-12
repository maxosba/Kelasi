using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelasi.Model;

namespace Kelasi.Repository.Repositories
{
    public interface IVideoRepository
    {
        ICollection <Course> GetAllVideos();
        Course GetVideoById(int videoId);
        ICollection<Course> GetVideosByCategory(Category category);
        ICollection<Course> GetVideosByTopic(Topic topic);
        ICollection<Course> GetVideoByAuthor(Author author);
        ICollection<Course> GetVideoByLanguage(Language language);


    }
}
