using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabajo2_Model;

namespace Trabajo2_WCF.Dominio.Accion
{
    public class Estacionamientos
    {

        public IList<Estacionamiento> ListadoderegistrosenEstacionamientoporrangodefechas(DateTime FechaHoraIngreso, DateTime FechaHoraSalida)
        {
            var elRepositorio = new Repositorio.Estacionamientos();
            var elResultado = elRepositorio.ListadoderegistrosenEstacionamientoporrangodefechas(FechaHoraIngreso, FechaHoraSalida);
            return elResultado;
        }

        internal IList<Estacionamiento> ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(string NombreProvincia)
        {
            var elRepositorio = new Repositorio.Estacionamientos();
            var elResultado = elRepositorio.ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(NombreProvincia);
            return elResultado;
        }
    }
}