using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tarea2_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Tarea2_WCF_Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Tarea2_WCF_Service1.svc or Tarea2_WCF_Service1.svc.cs at the Solution Explorer and start debugging.
    //public class Tarea2_WCF_Service1 : ITarea2_WCF_Service1
    //{
    //    public void DoWork()
    //    {
    //    }
    //}
    public class Tarea2_WCF_Service1 : DataService<ExamenAnalisisEntities>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
        }
        
       
    }
}
