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
    
    public partial class THAM_GIA
    {
        public int Ms { get; set; }
        public int Mtg { get; set; }
        public string Vai_tro { get; set; }
    
        public virtual SACH SACH { get; set; }
        public virtual TAC_GIA TAC_GIA { get; set; }
    }
}
