using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Trabajo2_Model;

namespace Trabajo2_WCF.Dominio.Interfaz
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        IList<Estacionamiento> ListadoderegistrosenEstacionamientoporrangodefechas(DateTime FechaHoraIngreso, DateTime FechaHoraSalida);

        //[OperationContract]
        //IList<Provincia> ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(int NombreProvincia);

        [OperationContract]
        IList<Estacionamiento> ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(string NombreProvincia);


        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
