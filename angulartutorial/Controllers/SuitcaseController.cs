using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AngularTutorial.Models;

namespace AngularTutorial.Controllers
{
    public class SuitcaseController : Controller
    {
        //
        // GET: /SuitCase/

        public ActionResult Index()
        {
            return View();
        }

	    public ActionResult AddSuitcase()
	    {
		    return View();
	    }

	    public ActionResult DetailSuitcase()
	    {
		    return View();
	    }

	    public ActionResult EditSuitcase()
	    {
		    return View();
	    }

		[System.Web.Mvc.HttpPost]
	    public IEnumerable<Suitcase> GetAllSuitcases()
		{
			List<Suitcase> suitcases = new List<Suitcase>
			{
				new Suitcase {Id = 1, Locked = true, Wheels = 4},
				new Suitcase {Id = 2, Locked = false, Wheels = 2}
			};

			Singleton.Instance.Suitcases = suitcases;

		    return suitcases;
	    }
    }
}
