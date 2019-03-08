using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2_Model
{
    public partial class Estacionamiento
    {
        [DataMember]
        public string Estacionamiento_info
        {
            get
            {
                string elResultado = FechaHoraIngreso.Date.ToString("dd");
                return elResultado;
            }
            set { }
        }

    }

}
