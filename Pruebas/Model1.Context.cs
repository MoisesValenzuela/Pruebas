﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pruebas
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PruebaEntities : DbContext
    {
        public PruebaEntities()
            : base("name=PruebaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activos> Activos { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Opcion> Opcion { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<RolUsuario> RolUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
