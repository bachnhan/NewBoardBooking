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
    
    public partial class tbRoleViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<HmsService.Models.Entities.tbRole>
    {
    	
    			public virtual int RoleID { get; set; }
    			public virtual string RoleName { get; set; }
    	
    	public tbRoleViewModel() : base() { }
    	public tbRoleViewModel(HmsService.Models.Entities.tbRole entity) : base(entity) { }
    
    }
}
