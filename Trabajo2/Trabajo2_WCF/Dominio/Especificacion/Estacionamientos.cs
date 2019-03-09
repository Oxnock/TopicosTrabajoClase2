using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajo2_Model;

namespace Trabajo2_WCF.Dominio.Especificacion
{
    public class Estacionamientos
    {
        public IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorRangoDeFechas(DateTime FechaHoraIngreso, DateTime FechaHoraSalida)
        {
            var laAccion = new Accion.Estacionamientos();
            var elResultado = laAccion.ListadoDeRegistrosEnEstacionamientoPorRangoDeFechas(FechaHoraIngreso, FechaHoraSalida);
            return elResultado;
        }

        public IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorProvinciaEnQueSeEncuentraElParqueo(string NombreProvincia)
        {
            var laAccion = new Accion.Estacionamientos();
            var elResultado = laAccion.ListadoDeRegistrosEnEstacionamientoPorProvinciaEnQueSeEnuentraElParqueo(NombreProvincia);
            return elResultado;
        }


    }
}