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
    
    public partial class tbSessionViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<HmsService.Models.Entities.tbSession>
    {
    	
    			public virtual int SsID { get; set; }
    			public virtual Nullable<int> SID { get; set; }
    			public virtual Nullable<int> Capital { get; set; }
    			public virtual Nullable<int> Available { get; set; }
    			public virtual Nullable<System.DateTime> DayCreate { get; set; }
    			public virtual Nullable<System.TimeSpan> StartTime { get; set; }
    			public virtual Nullable<System.TimeSpan> EndTime { get; set; }
    	
    	public tbSessionViewModel() : base() { }
    	public tbSessionViewModel(HmsService.Models.Entities.tbSession entity) : base(entity) { }
    
    }
}