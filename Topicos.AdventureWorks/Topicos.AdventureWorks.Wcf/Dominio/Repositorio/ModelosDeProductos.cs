using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Topicos.AdventureWorks.Model;

namespace Topicos.AdventureWorks.Wcf.Dominio.Repositorio
{
    internal class ModelosDeProductos
    {
        static private AdventureWorks2017Entities _contexto = new AdventureWorks2017Entities();

        public ModelosDeProductos()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public ModelosDeProductos(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }

        internal ProductModel BuscarModeloDeProducto (int? idProductModel)
        {
            var elResultado = _contexto.ProductModels.Find(idProductModel);
            return elResultado;
        }
    }
}