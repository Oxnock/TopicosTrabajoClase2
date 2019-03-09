using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajo2_Model;

namespace Trabajo2_WCF.Dominio.Repositorio
{
    public class Estacionamientos
    {
        static private Trabajo2Entities _contexto = new Trabajo2Entities();

        public Estacionamientos()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Estacionamientos(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }

        internal IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorRangodeFechas(DateTime FechaHoraIngreso, DateTime FechaHoraSalida)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();

            elResultado = _contexto.Estacionamiento
             .Where(F => F.FechaHoraIngreso >= FechaHoraIngreso)
             .Where(F => F.FechaHoraSalida <= FechaHoraSalida).ToList();
            return elResultado;
        }

        internal IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorProvinciaEnQueSeEncuentraElParqueo(string NombreProvincia)
        {
           

            IList<Estacionamiento> elResultado = new List<Estacionamiento>();

            elResultado = (from E in _contexto.Estacionamiento
                           join P in _contexto.Parqueo on
                           E.IDParqueo equals P.IDParqueo
                           join D in _contexto.Distrito on
                           P.ConsecutivoDistrito equals D.ConsecutivoDistrito
                           join Pr in _contexto.Provincia on
                           D.IDProvincia equals Pr.IDProvincia
                           where Pr.Descripcion == NombreProvincia
                           select E).Take(5).ToList();
            return elResultado;

        }



    }
}
