using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoClase3.Models;

namespace TrabajoClase3.Controllers
{
    public class MultiplicarController : Controller
    {
        // GET: Multiplicar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(Multiplicacion model, string command)
        {
            if (command=="multiplicar")
            {
                model.Resultado = model.NumeroA * model.NumeroB;
            }
            else {
                model.Resultado = model.NumeroA + model.NumeroB;
            }
    
            return View(model);
        }
    }
}