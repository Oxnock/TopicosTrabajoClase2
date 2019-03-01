using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tarea3._0;

namespace Tarea3._0_WCF.Dominios
{

    internal class Estacionamiento
    {
        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        //public Estacionamiento()
        //{
        //    _contexto.Configuration.ProxyCreationEnabled = false;
        //    _contexto.Configuration.LazyLoadingEnabled = true;
        //}

        //public Estacionamiento(bool lazyLoadingEnabled)
        //{
        //    _contexto.Configuration.ProxyCreationEnabled = false;
        //    _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        //}
        internal IList<Estacionamiento> DiasFeriados()
        {
            var Dias = new DiasFeriadosAnuales();
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();
            elResultado = _contexto.Estacionamiento.Where(p => p.FechaHoraIngreso.DayOfYear ==Dias.).ToList();
               

            /*
            IList<Product> elResultado = new List<Product>();
            elResultado = _contexto.Products.Include("").Where(
                p => precioInferior <= p.ListPrice && p.ListPrice <= precioSuperior).OrderByDescending(o => o.Name).ToList();
            */
            /*
            elResultado = _contexto.Products.Where(
                p => precioInferior <= p.ListPrice && p.ListPrice <= precioSuperior).OrderByDescending(o => o.Name).Select(s => new Product {ProductID = s.ProductID,
                    Name = s.Name,
                    MakeFlag = s.MakeFlag}).ToList();

             */
            var elNuevoResultado = CompletarPropiedadesDeNavegacion(elResultado);
            return elNuevoResultado;
        }

        internal DiasFeriadosAnuales BuscarDias(int? idDias)
        {
            var elResultado = _contexto.DiasFeriadosAnuales.Find(idDias);
            return elResultado;
        }

        private IList<Product> CompletarPropiedadesDeNavegacion(IList<Product> laListaDeProductos)
        {
            var elRepositorioDeProductModels = new ModelosDeProductos();
            var elRepositorioDeSubcategory = new Subcategorias();
            var elRepositorioDeCategory = new Categorias();
            IList<Product> elResultado = new List<Product>();
            foreach (var elProducto in laListaDeProductos)
            {
                if (elProducto.ProductModelID != null)
                {
                    elProducto.ProductModelName = elRepositorioDeProductModels.BuscarModeloDeProducto(elProducto.ProductModelID).Name;
                }
                if (elProducto.ProductSubcategoryID != null)
                {
                    var laSubCategoria = elRepositorioDeSubcategory.BuscarSubcategoria(elProducto.ProductSubcategoryID);
                    elProducto.ProductSubCategoryName = laSubCategoria.Name;
                    elProducto.ProductCategoryName = elRepositorioDeCategory.BuscarCategoria(laSubCategoria.ProductCategoryID).Name;
                }
                elResultado.Add(elProducto);
            }
            return elResultado;
        }
    }
}
}