using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;

namespace LabDos.WCF.Dominio.Repositorio
{
    internal class Estacionamiento
    {
        private static ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();
        public Estacionamiento()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Estacionamiento(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal IList<Estacionamiento> ListarEstacionamientoPorFecha(string fechaInicial, string fechaFinal)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();
            elResultado = _contexto.Estacionamientoes.Where(
                p => fechaFinal <= p.FechaHoraSalida && p.FechaHoraIngresp <= fechaInicial).OrderByDescending(o => o.FechaHoraIngreso).ToList();
            return elResultado;
        }
        internal IList<Estacionamiento> ListarEstacionamientoPorProvincia(string provincia)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();

            elResultado = _contexto.Database.SqlQuery<string>(
       "Select IDParqueo, IDVehiculo From Estacionamiento Where IDParqueo " +
       "IN select ConsecutivoDistrito From Parqueo  Where ConsecutivoDistrito " +
       "IN Select IDCanton From Distrito Where ID Canton IN Select ID Provincia " +
       "From Canton Where IDProvincia IN Select Descripcion From Provincia where IDProvincia==" + provincia).ToList();
            return elResultado;
        }




    }
}