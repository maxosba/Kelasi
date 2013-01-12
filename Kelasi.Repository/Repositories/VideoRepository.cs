using System;
using System.Collections.Generic;
using System.Linq;
using Kelasi.Model;

namespace Kelasi.Repository.Repositories
{
    public class VideoRepository :RepositoryBase<Kelasi>, IVideoRepository
    {
        public ICollection<Course> GetAllVideos()
        {
            using (var cxt = DataContext)
            {
                return cxt.Videos.ToList();
            }
        }

        public Course GetVideoById(int videoId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Course> GetVideosByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public ICollection<Course> GetVideosByTopic(Topic topic)
        {
            throw new NotImplementedException();
        }

        public ICollection<Course> GetVideoByAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public ICollection<Course> GetVideoByLanguage(Language language)
        {
            throw new NotImplementedException();
        }
    }
}
