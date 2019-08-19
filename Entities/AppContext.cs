using System;
using CarServiceFronted.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoNetCoreCarService.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ServiceStatus> ServiceStatus { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ServiceStatus>().HasData(new ServiceStatus { ID  = Guid.NewGuid(), Descripcion = "Pending   ", IdStatus = 10 });
            builder.Entity<ServiceStatus>().HasData(new ServiceStatus { ID  = Guid.NewGuid(),Descripcion = "InProgress", IdStatus = 20 });
            builder.Entity<ServiceStatus>().HasData(new ServiceStatus { ID  = Guid.NewGuid(),Descripcion = "Delayed   ", IdStatus = 30 });
            builder.Entity<ServiceStatus>().HasData(new ServiceStatus { ID  = Guid.NewGuid(),Descripcion = "Ended     ", IdStatus = 40 });
            
            builder.Entity<Brand>().HasData(
                new Brand { ID  = Guid.NewGuid(),Descripcion = "Renault",
                models="Captur,Clio,Clio Grandtour,Espace,Express,Fluence,Grand Espace,Grand Modus,Grand Scenic,Kadjar,Kangoo,Kangoo Express,Koleos,Laguna,Laguna Grandtour,Latitude,Mascott,Mégane,Mégane CC,Mégane Combi,Mégane Grandtour,Mégane Coupé,Mégane Scénic,Scénic,Talisman,Talisman Grandtour,Thalia,Twingo,Wind,Zoé" 
                }
            );
            // builder.Entity<TodoItem>().HasData(
            //     new TodoItem
            //     {
            //         Id  = Guid.NewGuid(),
            //         Title = "Curso React",
            //         DueAt = DateTimeOffset.Now.AddDays(1)
            //     }
            // );

            base.OnModelCreating(builder);
        }
    }
}