using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabajo3Multiplicacion.Models;

namespace Trabajo3Multiplicacion.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //[HttpPost]
        //public ActionResult Index(Multiplicar model, string command)
        //{
        //    if (command == "add")
        //    {
        //        model.Resultado = model.A + model.B;
        //    }
        //    if (command == "mul")
        //    {
        //        model.Resultado = model.A * model.B;
        //    }
          
        //    return View(model);
        //}

        [HttpPost]
        public ActionResult Index(Multiplicar model, string Multi, string command)
        {
            if (command =="add")
            {
                if (Multi == "true")
                {
                    model.Resultado = model.A * model.B;
                }
                else
                {
                    model.Resultado = model.A + model.B;
                }
            }
           

            return View(model);
        }



    }
}