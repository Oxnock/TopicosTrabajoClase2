using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;
namespace LabDos.WCF.Dominio.Repositorio
{
    internal class Vehiculo
    {
        static private ExamenAnalisisEntities  _contexto = new ExamenAnalisisEntities();
        public Vehiculo()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Vehiculo(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal Vehiculo BuscarVehiculo(int? IDVehiculo)
        {
            var elResultado = _contexto.Vehiculoes.Find(IDVehiculo);
            return elResultado;
        }
    }
}