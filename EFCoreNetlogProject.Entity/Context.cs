using EFCoreNetlogProject.Entity.Model;
using Microsoft.EntityFrameworkCore;
using NetlogProject.Entity.Model;
using System;

namespace NetlogProject.Entity
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ActionType> ActionType { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<MaintenanceHistory> MaintenanceHistory { get; set; }
        public DbSet<PictureGroup> PictureGroup { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();
            //modelBuilder.Entity<Maintenance>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();
            //modelBuilder.Entity<Vehicle>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();
            //modelBuilder.Entity<VehicleType>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();
            //modelBuilder.Entity<MaintenanceHistory>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();
            //modelBuilder.Entity<ActionType>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();
            //modelBuilder.Entity<Status>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();
            //modelBuilder.Entity<PictureGroup>()
            //            .Property(f => f.id)
            //            .ValueGeneratedOnAdd();

        }
    }
}