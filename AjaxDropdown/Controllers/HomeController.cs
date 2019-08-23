using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDropdown.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountries()
        {
            var countries = new List<String>();
            countries.Add("India");
            countries.Add("Austrelia");
            countries.Add("Russia");
            return Json(countries, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult GetStates(string country)
        {
            var States = new List<string>();
            if (!string.IsNullOrWhiteSpace(country))
            {
                if (country.Equals("Australia"))
                {
                    States.Add("Sydney");
                    States.Add("Perth");
                }
                if (country.Equals("India"))
                {
                    States.Add("Delhi");
                    States.Add("Mumbai");
                }
                if (country.Equals("Russia"))
                {
                    States.Add("Minsk");
                    States.Add("Moscow");
                }
            }
            return Json(States, JsonRequestBehavior.AllowGet);
        }
    }
}