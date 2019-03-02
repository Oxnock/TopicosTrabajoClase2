using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LabDos.Model.MisClases
{
    public partial class Distrito
    {
        [DataMember]
        public string IDProvincia { get; set; }
        [DataMember]
        public string IDCanton { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string ConsecutivoDistrito { get; set; }
    }
}
