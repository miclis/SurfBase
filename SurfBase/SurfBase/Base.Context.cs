﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurfBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BaseContainer : DbContext
    {
        public BaseContainer()
            : base("name=BaseContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hangar> Hangars { get; set; }
        public virtual DbSet<Rig> Rigs { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<Sail> Sails { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Hour> Hours { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<RentalHistory> RentalHistory { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    }
}
