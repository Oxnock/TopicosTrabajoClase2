using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoClase3.Models;

namespace TrabajoClase3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Index(Multiplicacion model, string command)
        {
            if (command == "multiplicar")
            {
                model.Resultado = model.NumeroA * model.NumeroB;
            }
            else
            {
                model.Resultado = model.NumeroA + model.NumeroB;
            }

            return View(model);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}