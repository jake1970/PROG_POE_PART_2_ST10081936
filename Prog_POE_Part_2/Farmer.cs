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
    
    public partial class Farmer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Farmer()
        {
            this.FarmerProductLists = new HashSet<FarmerProductList>();
        }
    
        public int FarmerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int LoginID { get; set; }
    
        public virtual LoginData LoginData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FarmerProductList> FarmerProductLists { get; set; }
    }
}