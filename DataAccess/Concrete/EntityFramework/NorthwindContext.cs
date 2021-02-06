using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localDb)\mssqllocaldb; Database=ReCapBase; Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Cars");

            modelBuilder.Entity<Car>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Car>().Property(c => c.BrandId).HasColumnName("BrandId");
            modelBuilder.Entity<Car>().Property(c => c.ColorId).HasColumnName("ColorId");
            modelBuilder.Entity<Car>().Property(c => c.Description).HasColumnName("Name");
            modelBuilder.Entity<Car>().Property(c => c.ModelYear).HasColumnName("ModelYear");
            modelBuilder.Entity<Car>().Property(c => c.DailyPrice).HasColumnName("DailyPrice");

            modelBuilder.Entity<Brand>().ToTable("Brands");

            modelBuilder.Entity<Brand>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Brand>().Property(c => c.Name).HasColumnName("Name");
        }


    }
}
