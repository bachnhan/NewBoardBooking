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
    
    public partial class tbAppointmentViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<HmsService.Models.Entities.tbAppointment>
    {
    	
    			public virtual int AID { get; set; }
    			public virtual Nullable<int> SsID { get; set; }
    			public virtual Nullable<int> ASID { get; set; }
    			public virtual string CPhone { get; set; }
    			public virtual Nullable<System.DateTime> BookedDay { get; set; }
    			public virtual Nullable<System.DateTime> StartTime { get; set; }
    			public virtual Nullable<int> ACapital { get; set; }
    	
    	public tbAppointmentViewModel() : base() { }
    	public tbAppointmentViewModel(HmsService.Models.Entities.tbAppointment entity) : base(entity) { }
    
    }
}
