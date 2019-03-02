using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LabDos.Model.MisClases
{
    public partial class Estacionamiento
    {
        [DataMember]
        public string NombreFeriado { get; set; }
        [DataMember]
        public string FechaEntrada { get; set; }
        [DataMember]
        public string FechaSalida { get; set; }
        [DataMember]
        public int CantidadHoras { get; set; }
        [DataMember]
        public int CantidadMinutos { get; set; }
    }
}
