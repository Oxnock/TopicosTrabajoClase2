//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea3._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parqueo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parqueo()
        {
            this.Estacionamiento = new HashSet<Estacionamiento>();
        }
    
        public decimal IDParqueo { get; set; }
        public Nullable<decimal> ConsecutivoDistrito { get; set; }
    
        public virtual Distrito Distrito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estacionamiento> Estacionamiento { get; set; }
    }
}
