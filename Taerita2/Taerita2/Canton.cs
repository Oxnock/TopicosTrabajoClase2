//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taerita2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Canton
    {
        public Canton()
        {
            this.Distritoes = new HashSet<Distrito>();
        }
    
        public decimal IDProvincia { get; set; }
        public decimal IDCanton { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Distrito> Distritoes { get; set; }
    }
}