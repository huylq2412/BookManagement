﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBanSachEntities : DbContext
    {
        public QLBanSachEntities()
            : base("name=QLBanSachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHU_DE> CHU_DE { get; set; }
        public virtual DbSet<NHA_XUAT_BAN> NHA_XUAT_BAN { get; set; }
        public virtual DbSet<QUANG_CAO> QUANG_CAO { get; set; }
        public virtual DbSet<SACH> SACH { get; set; }
        public virtual DbSet<TAC_GIA> TAC_GIA { get; set; }
    }
}
