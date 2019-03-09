using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabajo3Multiplicacion.Models;

namespace Trabajo3Multiplicacion.Controllers
{
    public class MultiplicarController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Multiplicar model, string Multi, string command)
        {
            if (command == "Realizar")
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