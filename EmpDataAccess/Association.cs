//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Association
    {
        public int AssociationId { get; set; }
        public int EmpId { get; set; }
        public int CustId { get; set; }
        public int VendorId { get; set; }
        public int ProjId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Project Project { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}