using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajo2_Model;

namespace Trabajo2_WCF.Dominio.Accion
{
    public class Estacionamientos
    {

        public IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorRangoDeFechas(DateTime FechaHoraIngreso, DateTime FechaHoraSalida)
        {
            var elRepositorio = new Repositorio.Estacionamientos();
            var elResultado = elRepositorio.ListadoDeRegistrosEnEstacionamientoPorRangodeFechas(FechaHoraIngreso, FechaHoraSalida);
            return elResultado;
        }

        internal IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorProvinciaEnQueSeEnuentraElParqueo(string NombreProvincia)
        {
            var elRepositorio = new Repositorio.Estacionamientos();
            var elResultado = elRepositorio.ListadoDeRegistrosEnEstacionamientoPorProvinciaEnQueSeEncuentraElParqueo(NombreProvincia);
            return elResultado;
        }
    }
}