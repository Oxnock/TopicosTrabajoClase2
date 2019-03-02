using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Topicos.AdventureWorks.Model;

namespace Topicos.AdventureWorks.Wcf.Dominio.Repositorio
{
    internal class Subcategorias
    {
        static private AdventureWorks2017Entities _contexto = new AdventureWorks2017Entities();

        public Subcategorias()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Subcategorias(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal ProductSubcategory BuscarSubcategoria(int? idSubcategoria)
        {
            var elResultado = _contexto.ProductSubcategories.Find(idSubcategoria);
            return elResultado;
        }

    }
}