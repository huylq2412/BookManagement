//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_DAT_HANG
    {
        public int Mctddh { get; set; }
        public int Sdh { get; set; }
        public int Ms { get; set; }
        public Nullable<int> So_luong { get; set; }
        public Nullable<double> Don_gia { get; set; }
        public Nullable<double> Thanh_tien { get; set; }
    
        public virtual DON_DAT_HANG DON_DAT_HANG { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
