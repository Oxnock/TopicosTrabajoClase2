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
    
    public partial class Distrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Distrito()
        {
            this.Parqueos = new HashSet<Parqueo>();
        }
    
        public decimal ConsecutivoDistrito { get; set; }
        public Nullable<decimal> IDProvincia { get; set; }
        public Nullable<decimal> IDCanton { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Canton Canton { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parqueo> Parqueos { get; set; }
    }
}
