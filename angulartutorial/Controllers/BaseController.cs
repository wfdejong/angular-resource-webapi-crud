using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTutorial.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Basi/

        public ActionResult Index()
        {
            return View();
        }

    }
}
