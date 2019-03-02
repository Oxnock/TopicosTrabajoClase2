using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Topicos.AdventureWorks.Model;

namespace Topicos.AdventureWorks.Wcf.Dominio.Especificacion
{
    public class Productos
    {
        public IList<Product> ListarProductosPorRangoDePrecio(decimal precioInferior, decimal precioSuperior)
        {
            var laAccion = new Accion.Productos();
            var elResultado = laAccion.ListarProductosPorRangoDePrecio(precioInferior, precioSuperior);
            return elResultado;
        }

    }
}