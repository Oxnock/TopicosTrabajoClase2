using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Trabajo2_Model;
using Trabajo2_WCF.Dominio.Interfaz;

namespace Trabajo2_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorRangoDeFechas(DateTime FechaHoraIngreso, DateTime FechaHoraSalida)
        {
            var laEspecificacion = new Trabajo2_WCF.Dominio.Especificacion.Estacionamientos();
            var elResultado = laEspecificacion.ListadoDeRegistrosEnEstacionamientoPorRangoDeFechas(FechaHoraIngreso, FechaHoraSalida);
            return elResultado;
        }

        public IList<Estacionamiento> ListadoDeRegistrosEnEstacionamientoPorProvinciaEnQueSeEncuentraElParqueo(string NombreProvincia)
        {
            var LaEspecificacion = new Trabajo2_WCF.Dominio.Especificacion.Estacionamientos();
            var elResultado = LaEspecificacion.ListadoDeRegistrosEnEstacionamientoPorProvinciaEnQueSeEncuentraElParqueo(NombreProvincia);
            return elResultado;
        }

     

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
