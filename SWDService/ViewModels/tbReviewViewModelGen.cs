//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HmsService.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbReviewViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<HmsService.Models.Entities.tbReview>
    {
    	
    			public virtual string RID { get; set; }
    			public virtual string CPhone { get; set; }
    			public virtual Nullable<int> SID { get; set; }
    			public virtual Nullable<System.DateTime> Date { get; set; }
    			public virtual Nullable<double> RatingNumber { get; set; }
    			public virtual string Comment { get; set; }
    	
    	public tbReviewViewModel() : base() { }
    	public tbReviewViewModel(HmsService.Models.Entities.tbReview entity) : base(entity) { }
    
    }
}
