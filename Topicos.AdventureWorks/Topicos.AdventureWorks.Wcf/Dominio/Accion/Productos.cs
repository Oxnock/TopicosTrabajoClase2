using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Topicos.AdventureWorks.Model;

namespace Topicos.AdventureWorks.Wcf.Dominio.Accion
{
    public class Productos
    {
        public IList<Product> ListarProductosPorRangoDePrecio(decimal precioInferior, decimal precioSuperior)
        {
            var elRepositorio = new Repositorio.Productos();
            var elResultado = elRepositorio.ListarProductosPorRangoDePrecio(precioInferior, precioSuperior);
            return elResultado;
        }

    }
}