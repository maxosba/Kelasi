using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kelasi.Repository.Repositories;

namespace Kelasi.UI.Web.Controllers
{
    public class CoursesController : Controller
    {
        //
        private IVideoRepository _repository = new VideoRepository();
        public ActionResult Index()
        {
            var videos = _repository.GetAllVideos();
            return View(videos);
        }

    }
}
