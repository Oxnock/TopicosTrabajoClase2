using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;
using System.Data.Entity;
namespace LabDos.WCF.Dominio.Repositorio
{
    internal class Provincia
    {
        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        public Provincia()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Provincia(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal Provincia BuscarProvincia(int? IDProvincia)
        {
            var elResultado = _contexto.Provincias.Find(IDProvincia);
            return elResultado;
        }
    }
}