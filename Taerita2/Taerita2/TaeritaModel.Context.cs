﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taerita2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExamenAnalisisEntities : DbContext
    {
        public ExamenAnalisisEntities()
            : base("name=ExamenAnalisisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Canton> Cantons { get; set; }
        public DbSet<Continente> Continentes { get; set; }
        public DbSet<DiasFeriadosAnuale> DiasFeriadosAnuales { get; set; }
        public DbSet<Distrito> Distritoes { get; set; }
        public DbSet<Estacionamiento> Estacionamientoes { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Pai> Pais { get; set; }
        public DbSet<Parqueo> Parqueos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<RegionContinente> RegionContinentes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculoes { get; set; }
        public DbSet<Vehiculo> Vehiculoes { get; set; }
    }
}
