﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaptchaManager.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CaptchaManagerEntities : DbContext
    {
        public CaptchaManagerEntities()
            : base("name=CaptchaManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<captchas> captchas { get; set; }
        public DbSet<imagesComplex> imagesComplex { get; set; }
        public DbSet<imagesFormat> imagesFormat { get; set; }
        public DbSet<soundsFormat> soundsFormat { get; set; }
        public DbSet<users> users { get; set; }
    }
}