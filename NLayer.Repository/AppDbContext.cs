﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext:DbContext
    {//ctor'un options seçmemizin sebebi startup.cs üzerinden path vermemizden kaynaklanıyor
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            // productRepository.add(new Product)
            //var p = new Product() { ProductFeature = new ProductFeature() };
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }


        //model çalışırken çalışacak olan metotum
        //burayı Configurations > altına taşıdım
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
          //modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color= "Kırmızı",
                Height=100,
                Width = 200,
                ProductId = 1
            },
            new ProductFeature()
            {
                Id = 2,
                Color = "Mavi",
                Height = 300,
                Width = 500,
                ProductId = 2
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}