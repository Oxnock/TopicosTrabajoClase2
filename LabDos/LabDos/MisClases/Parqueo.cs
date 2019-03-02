using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LabDos.Model.MisClases
{
    public partial class Parqueo
    {
        [DataMember]
        public string NombreDistrito { get; set; }
        [DataMember]
        public string NombreCanton { get; set; }
        [DataMember]
        public string NombreProvincia { get; set; }
    }
}
