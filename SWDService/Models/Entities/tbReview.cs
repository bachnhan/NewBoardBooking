//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HmsService.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbReview
    {
        public string RID { get; set; }
        public string CPhone { get; set; }
        public Nullable<int> SID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> RatingNumber { get; set; }
        public string Comment { get; set; }
    
        public virtual tbCustomer tbCustomer { get; set; }
        public virtual tbStore tbStore { get; set; }
    }
}
