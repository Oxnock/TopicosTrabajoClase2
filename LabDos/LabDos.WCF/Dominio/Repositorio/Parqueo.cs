using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;
using System.Data.Entity;

namespace LabDos.WCF.Dominio.Repositorio
{
    internal class Parqueo
    {
        static private  ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        public Parqueo()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Parqueo(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal Parqueo BuscarParqueo(int? IDParqueo)
        {
            var elResultado = _contexto.Parqueos.Find(IDParqueo);
            return elResultado;
        }
    }
}