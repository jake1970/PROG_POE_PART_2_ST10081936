//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prog_POE_Part_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class FarmerProductList
    {
        public int FarmerProductListID { get; set; }
        public int FarmerID { get; set; }
        public int ProductID { get; set; }
    
        public virtual Farmer Farmer { get; set; }
        public virtual Product Product { get; set; }
    }
}
