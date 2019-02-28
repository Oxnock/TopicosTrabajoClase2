using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Web;

namespace Tarea3._0.MisClases
{
    public class Vehiculo
    {
        [DataMember]
        public string VehiculoNombreFabricante { get; set; }
        [DataMember]
        public string VehiculoNombrePais { get; set; }
        [DataMember]
        public string VehiculoNombreRegion { get; set; }
        [DataMember]
        public string VehiculoNombreContinente { get; set; }
        [DataMember]
        public string VehiculoAntiguedad { get; set; }
        [DataMember]
        public string VehiculoNombreTipo { get; set; }
    }
}