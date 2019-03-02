using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Topicos.AdventureWorks.Model;

namespace Topicos.AdventureWorks.Wcf.Dominio.Repositorio
{
    internal class Productos
    {
        static private AdventureWorks2017Entities _contexto = new AdventureWorks2017Entities();

        public Productos()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Productos(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }

        internal  IList<Product> ListarProductosPorRangoDePrecio (decimal precioInferior, decimal precioSuperior)
        {
            IList<Product> elResultado = new List<Product>();
            elResultado = _contexto.Products.Where(
                p => precioInferior <= p.ListPrice && p.ListPrice <= precioSuperior).OrderByDescending(o => o.Name).ToList();

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