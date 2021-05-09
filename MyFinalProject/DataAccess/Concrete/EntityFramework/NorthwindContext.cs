using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context: Db tablolari ile proje classlarini baglamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");//kullanici adi ve sifreye gerek yok true oldugu icin
        }
        public DbSet<Product> Products { get; set; } //hangi class hangi tabloya geliyor bunları belirtir.
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Customer> Customers { get; set; } 
    }
}
