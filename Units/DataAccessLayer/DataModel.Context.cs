﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Units.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_GRPMST> tbl_GRPMST { get; set; }
        public virtual DbSet<tbl_ITEMAS> tbl_ITEMAS { get; set; }
        public virtual DbSet<tbl_UNTMST> tbl_UNTMST { get; set; }
    }
}