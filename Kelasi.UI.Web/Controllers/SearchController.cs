using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kelasi.UI.Web.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
         
        public ActionResult Search(RouteInfo routeValues)
        {
            var actionName = "Search";
            var controllerName = SearchHelper.GetControllerName(routeValues.Category);
            return RedirectToAction(actionName, controllerName, routeValues);
        }

    }
}
