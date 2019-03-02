using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;
using System.Data.Entity;
namespace LabDos.WCF.Dominio.Repositorio
{
    internal class Distrito
    {
        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        public Distrito()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Distrito(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal Distrito BuscarDistrito(int? IDDistrito)
        {
            var elResultado = _contexto.Distritoes.Find(IDDistrito);
            return elResultado;
        }
    }
}