using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tablolari ile proje classlarını bağlamak
public    class NortwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=DESKTOP-7B09P62;Initial Catalog=Northwind;Integrated Security=Tru

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7B09P62;Database=Northwind; Trusted_Connection=true");
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Order> Orders{ get; set; }
    }
}
