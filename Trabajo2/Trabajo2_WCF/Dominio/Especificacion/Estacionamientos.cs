using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajo2_Model;

namespace Trabajo2_WCF.Dominio.Especificacion
{
    public class Estacionamientos
    {
        public IList<Estacionamiento> ListadoderegistrosenEstacionamientoporrangodefechas(DateTime FechaHoraIngreso, DateTime FechaHoraSalida)
        {
            var laAccion = new Accion.Estacionamientos();
            var elResultado = laAccion.ListadoderegistrosenEstacionamientoporrangodefechas(FechaHoraIngreso, FechaHoraSalida);
            return elResultado;
        }

        public IList<Estacionamiento> ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(string NombreProvincia)
        {
            var laAccion = new Accion.Estacionamientos();
            var elResultado = laAccion.ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(NombreProvincia);
            return elResultado;
        }


    }
}