using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {

        Context c = new Context();


        // GET: About
        public ActionResult Index()
        {
            var degerler = c.Hakkımızdas.ToList();
            return View(degerler);
        }
    }
}