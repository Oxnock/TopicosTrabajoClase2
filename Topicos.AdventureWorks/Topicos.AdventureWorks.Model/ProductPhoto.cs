
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Topicos.AdventureWorks.Model
{

using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization; 
[DataContract] public partial class ProductPhoto
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ProductPhoto()
    {

        this.ProductProductPhotoes = new HashSet<ProductProductPhoto>();

    }


    [DataMember] public int ProductPhotoID { get; set; }

    [DataMember] public byte[] ThumbNailPhoto { get; set; }

    [DataMember] public string ThumbnailPhotoFileName { get; set; }

    [DataMember] public byte[] LargePhoto { get; set; }

    [DataMember] public string LargePhotoFileName { get; set; }

    [DataMember] public System.DateTime ModifiedDate { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; }

}

}
