﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tablolari ile proje classlarını bağlamak
public    class NortwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DataSource=DESKTOP-7B09P62;Initial Catalog=Northwind;Integrated Security=Tru

             optionsBuilder.UseSqlServer(@"Server=DESKTOP-7B09P62;Database=Northwind; Trusted_Connection=true");

            //optionsBuilder.UseSqlServer(@"workstation id=Northwinds.mssql.somee.com;packet size=4096;user id=mahsum12_SQLLogin_1;pwd=7ndi393yjy;data source=Northwinds.mssql.somee.com;persist security info=False;initial catalog=Northwinds");
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
