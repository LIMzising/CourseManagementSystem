﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnologyCourseSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TechnologyCourseSystem_DatabaseEntities : DbContext
    {
        public TechnologyCourseSystem_DatabaseEntities()
            : base("name=TechnologyCourseSystem_DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
    }
}