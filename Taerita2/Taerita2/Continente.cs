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
    
    public partial class Continente
    {
        public Continente()
        {
            this.RegionContinentes = new HashSet<RegionContinente>();
        }
    
        public decimal IDContinente { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<RegionContinente> RegionContinentes { get; set; }
    }
}
