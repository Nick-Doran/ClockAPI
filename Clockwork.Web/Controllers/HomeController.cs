using Clockwork.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Clockwork.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewBag.Title = "Clockwork Web Project";
            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            CurrentTimeQuery model = new CurrentTimeQuery();
            return View(model);
        }

        public ActionResult SeeAllQueries()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewBag.Title = "Clockwork Web Project";
            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            CurrentTimeQueries queries = new CurrentTimeQueries();
            List<CurrentTimeQuery> list = new List<CurrentTimeQuery>();
            


            return View();
        }

       
    }
}
