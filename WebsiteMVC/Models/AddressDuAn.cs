//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddressDuAn
    {
        public int IDAddressDuAn { get; set; }
        public Nullable<int> IDDuAn { get; set; }
        public Nullable<int> IDAddress { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual DuAn DuAn { get; set; }
    }
}
