//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrarySystem.Models.ENTITY
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryManagementSystemEntities3 : DbContext
    {
        public LibraryManagementSystemEntities3()
            : base("name=LibraryManagementSystemEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN> ADMIN { get; set; }
        public virtual DbSet<AUTHORS> AUTHORS { get; set; }
        public virtual DbSet<BOOK> BOOK { get; set; }
        public virtual DbSet<CATEGORY> CATEGORY { get; set; }
        public virtual DbSet<PURCHASE> PURCHASE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
    }
}
