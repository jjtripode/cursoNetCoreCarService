using CarServiceFronted.Models;
using CursoNetCoreCarService.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoNetCoreCarService.Entities
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

       public DbSet<Car> Cars {get;set;}
       public DbSet<CarService> Services {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder.Entity<TodoItem>().HasData(
            //     new TodoItem
            //     {
            //         Id  = Guid.NewGuid(),
            //         Title = "Curso ASP.NET Core UTN",
            //         DueAt = DateTimeOffset.Now.AddDays(1)
            //     }
            // );

            // builder.Entity<TodoItem>().HasData(
            //     new TodoItem
            //     {
            //         Id  = Guid.NewGuid(),
            //         Title = "Curso React",
            //         DueAt = DateTimeOffset.Now.AddDays(1)
            //     }
            // );

            // base.OnModelCreating(builder);
        }
    }
}