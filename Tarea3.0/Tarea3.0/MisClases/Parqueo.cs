using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Web;

namespace Tarea3._0.MisClases
{
    public class Parqueo
    {
        [DataMember]
        public string ParqueoProvincia { get; set; }
        [DataMember]
        public string ParqueoCanton { get; set; }
        [DataMember]
        public string ParqueoDistrito { get; set; }
    }
}