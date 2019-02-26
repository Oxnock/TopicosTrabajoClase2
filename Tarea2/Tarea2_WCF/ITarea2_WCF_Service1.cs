using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tarea2_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITarea2_WCF_Service1" in both code and config file together.
    [ServiceContract]
    public interface ITarea2_WCF_Service1
    {
        [OperationContract]
        void DoWork();
    }
}
