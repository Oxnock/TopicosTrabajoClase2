using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Topicos.AdventureWorks.Model;

namespace Topicos.AdventureWorks.Wcf.Dominio.Repositorio
{
    internal class Categorias
    {
        static private AdventureWorks2017Entities _contexto = new AdventureWorks2017Entities();

        public Categorias()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Categorias(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }

        internal ProductCategory BuscarCategoria (int idCategoria)
        {
            var elResultado = _contexto.ProductCategories.Find(idCategoria);
            return elResultado;
        }
    }
}