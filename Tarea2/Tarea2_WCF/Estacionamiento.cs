//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea2_WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estacionamiento
    {
        public decimal IDParqueo { get; set; }
        public decimal IDVehiculo { get; set; }
        public System.DateTime FechaHoraIngreso { get; set; }
        public Nullable<System.DateTime> FechaHoraSalida { get; set; }
        public Nullable<decimal> TarifaBase { get; set; }
        public Nullable<decimal> Ganancia { get; set; }
        public Nullable<decimal> Mantenimiento { get; set; }
        public Nullable<decimal> ImpVentas { get; set; }
        public Nullable<decimal> TotalACobrar { get; set; }
    
        public virtual Parqueo Parqueo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
