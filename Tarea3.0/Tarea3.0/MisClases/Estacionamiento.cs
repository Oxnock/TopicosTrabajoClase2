using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Web;


namespace Tarea3._0.MisClases
{
    public class Estacionamiento
    {
        [DataMember]
        public string EstacionamientoFechaEntrada { get; set; }
        [DataMember]
        public string EstacionamientoFechaSalida { get; set; }
        [DataMember]
        public string EstacionamientoHora { get; set; }
       
    }
}