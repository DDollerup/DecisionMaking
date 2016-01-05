using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecisionMaking.Controllers
{
    public class HomeController : Controller
    {
        private int tal1 = 9;
        private int tal2 = 30;

        // GET: Home
        public ActionResult Index()
        {
            string resultat = "";
            // Spørger, er tal1 + tal2 mellem 40 og 60
            if (tal1 + tal2 >= 40 && tal1 + tal2 <= 60)
            {
                resultat = "Tallet er mellem 40 og 60 : " + (tal1 + tal2);
            }
            else if (tal1 + tal2 > 60)
            {
                resultat = "Tallet er større end 60 : " + (tal1 + tal2);
            }
            else
            {
                resultat = "Tallet er mindre end 40 : " + (tal1 + tal2);
            }

            ViewBag.Resultat = resultat;
            return View();
        }
    }
}