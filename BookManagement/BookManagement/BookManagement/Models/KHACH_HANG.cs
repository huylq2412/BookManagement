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
    
    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            this.DON_DAT_HANG = new HashSet<DON_DAT_HANG>();
        }
    
        public int Mkh { get; set; }
        public string Ho_ten { get; set; }
        public string Dia_chi { get; set; }
        public string Dien_thoai { get; set; }
        public string Ten_dang_nhap { get; set; }
        public string Mat_khau { get; set; }
        public Nullable<System.DateTime> Ngay_sinh { get; set; }
        public bool Gioi_tinh { get; set; }
        public string Email { get; set; }
        public Nullable<short> Quyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_DAT_HANG> DON_DAT_HANG { get; set; }
    }
}
