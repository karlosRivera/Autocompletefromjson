using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutocompleteSample.Models;

namespace AutocompleteSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new SampleViewModel();
            model.Countries = new List<Country>
            {
                new Country{name="Aland Islands"},
                new Country{name="Albania"},
                new Country{name="Bahamas"},
                new Country{name="Bahrain"},
                new Country{name="Bangladesh"},
                new Country{name="Cambodia"},
                new Country{name="Cameroon"},
                new Country{name="Canada"},
                new Country{name="Viet Nam"},
                new Country{name="Virgin Islands, British"},
                new Country{name="Yemen"},
                new Country{name="Zambia"}
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}