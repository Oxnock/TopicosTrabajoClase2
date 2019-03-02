using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;
using System.Data.Entity;
namespace LabDos.WCF.Dominio.Repositorio
{
    internal class Canton
    {
        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        public Canton()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Canton(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal Canton BuscarCanton(int? IDCanton)
        {
            var elResultado = _contexto.Cantons.Find(IDCanton);
            return elResultado;
        }
    }
}