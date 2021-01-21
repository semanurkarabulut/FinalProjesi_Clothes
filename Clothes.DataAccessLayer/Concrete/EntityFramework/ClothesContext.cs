﻿using Clothes.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clothes.DataAccessLayer.Concrete.EntityFramework
{
    public class ClothesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClothesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Clothe> Clothes { get; set; }
    }
}
