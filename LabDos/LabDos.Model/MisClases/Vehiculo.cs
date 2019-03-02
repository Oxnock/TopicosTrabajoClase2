using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LabDos.Model.MisClases
{
    public partial class Vehiculo
    {
        [DataMember]
        public string NombreFabricante { get; set; }
        [DataMember]
        public string NombrePais { get; set; }
        [DataMember]
        public string NombreRegion { get; set; }
        [DataMember]
        public string NombreContinente { get; set; }
        [DataMember]
        public int AntiguedadVehiculo { get; set; }
        [DataMember]
        public string NombreTipoVehiculo { get; set; }
    }
}
