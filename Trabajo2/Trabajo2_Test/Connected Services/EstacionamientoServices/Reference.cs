﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trabajo2_Test.EstacionamientoServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstacionamientoServices.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporrangodefechas", ReplyAction="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporrangodefechasR" +
            "esponse")]
        Trabajo2_Model.Estacionamiento[] ListadoderegistrosenEstacionamientoporrangodefechas(System.DateTime FechaHoraIngreso, System.DateTime FechaHoraSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporrangodefechas", ReplyAction="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporrangodefechasR" +
            "esponse")]
        System.Threading.Tasks.Task<Trabajo2_Model.Estacionamiento[]> ListadoderegistrosenEstacionamientoporrangodefechasAsync(System.DateTime FechaHoraIngreso, System.DateTime FechaHoraSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporprovinciaenque" +
            "seencuentraelparqueo", ReplyAction="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporprovinciaenque" +
            "seencuentraelparqueoResponse")]
        Trabajo2_Model.Estacionamiento[] ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(string NombreProvincia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporprovinciaenque" +
            "seencuentraelparqueo", ReplyAction="http://tempuri.org/IService1/ListadoderegistrosenEstacionamientoporprovinciaenque" +
            "seencuentraelparqueoResponse")]
        System.Threading.Tasks.Task<Trabajo2_Model.Estacionamiento[]> ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueoAsync(string NombreProvincia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Trabajo2_WCF.Dominio.Interfaz.CompositeType GetDataUsingDataContract(Trabajo2_WCF.Dominio.Interfaz.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Trabajo2_WCF.Dominio.Interfaz.CompositeType> GetDataUsingDataContractAsync(Trabajo2_WCF.Dominio.Interfaz.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Trabajo2_Test.EstacionamientoServices.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Trabajo2_Test.EstacionamientoServices.IService1>, Trabajo2_Test.EstacionamientoServices.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Trabajo2_Model.Estacionamiento[] ListadoderegistrosenEstacionamientoporrangodefechas(System.DateTime FechaHoraIngreso, System.DateTime FechaHoraSalida) {
            return base.Channel.ListadoderegistrosenEstacionamientoporrangodefechas(FechaHoraIngreso, FechaHoraSalida);
        }
        
        public System.Threading.Tasks.Task<Trabajo2_Model.Estacionamiento[]> ListadoderegistrosenEstacionamientoporrangodefechasAsync(System.DateTime FechaHoraIngreso, System.DateTime FechaHoraSalida) {
            return base.Channel.ListadoderegistrosenEstacionamientoporrangodefechasAsync(FechaHoraIngreso, FechaHoraSalida);
        }
        
        public Trabajo2_Model.Estacionamiento[] ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(string NombreProvincia) {
            return base.Channel.ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueo(NombreProvincia);
        }
        
        public System.Threading.Tasks.Task<Trabajo2_Model.Estacionamiento[]> ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueoAsync(string NombreProvincia) {
            return base.Channel.ListadoderegistrosenEstacionamientoporprovinciaenqueseencuentraelparqueoAsync(NombreProvincia);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Trabajo2_WCF.Dominio.Interfaz.CompositeType GetDataUsingDataContract(Trabajo2_WCF.Dominio.Interfaz.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Trabajo2_WCF.Dominio.Interfaz.CompositeType> GetDataUsingDataContractAsync(Trabajo2_WCF.Dominio.Interfaz.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
