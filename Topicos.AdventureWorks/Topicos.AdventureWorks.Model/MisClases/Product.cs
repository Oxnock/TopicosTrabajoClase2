using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Topicos.AdventureWorks.Model
{
    public partial class Product
    {     
        [DataMember]
        public decimal MyDiscountPrice { get
            {
                decimal elResultado = ListPrice;
                if ((Color != null)  && (Color.Substring(0, 1).ToUpper().Equals('B')))
                    elResultado = ListPrice * (decimal)0.7;
                if ((Color != null) && (Color.ToUpper().Substring(0, 1).Equals('S')))
                    elResultado = ListPrice * (decimal)0.85;
                return elResultado;
            } set { } }

        [DataMember]
        public string ProductModelName { get; set; }
        [DataMember]
        public string ProductSubCategoryName { get; set; }
        [DataMember]
        public string ProductCategoryName { get; set; }

    }
}
