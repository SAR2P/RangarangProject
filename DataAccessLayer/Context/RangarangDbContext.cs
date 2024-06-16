using BuisnesEntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class RangarangDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2BEGN3R;Database=RangarangDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<ProductE> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Order>().HasKey(x => x.Id);
            modelBuilder.Entity<OrderDetails>().HasKey(x => x.Id);
            modelBuilder.Entity<Person>().HasKey(x => x.Id);
            modelBuilder.Entity<ProductE>().HasKey(x => x.Id);

            modelBuilder.Entity<OrderDetails>().Ignore(x => x.EditState);
           
        }

       
    }
}
